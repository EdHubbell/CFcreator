using System;
using System.Linq;
using System.IO.Ports;
using NLog;
using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace XC_Common
{
    /// <summary>
    /// Shared code to communicate between an application and the LED driver board provided by the vendor/customer.
    /// </summary>
    public class COMDriverBoard
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public bool SimulatedPortForDebug = false;

        private SerialPort m_ComPort;

        private string msCOMPortAddress;

        // The initial development of this code involved a lot of trial and error because of the difference 
        // between the default newline character used by Terraterm and by .NET Serial port. 
        // We are now on the same page - Just make sure to set .NewLine = vbCr

        private string ADDRESS_UNLOCK = "#U";
        private string ADDRESS_RED = "#XP54";
        private string ADDRESS_GREEN = "#XP55";
        private string ADDRESS_BLUE = "#XP56";

        private string ADDRESS_COLOR_CURRENT = "#XP57";

        private string READ_VFS = "R";

        private string serialResponse = "";


        public enum LEDColors
        {
            Red,
            Green,
            Blue
        }

        private Dictionary<LEDColors, string> addressDict;

        public COMDriverBoard(string sCOMPortAddress)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);


                msCOMPortAddress = sCOMPortAddress;

                addressDict = new Dictionary<LEDColors, string>()
                                            {
                                                {LEDColors.Red, ADDRESS_RED},
                                                {LEDColors.Green, ADDRESS_GREEN},
                                                {LEDColors.Blue, ADDRESS_BLUE }
                                            };
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }
        }

        public static COMDriverBoard MakeSimulatedCOMDriverBoard(string sCOMPortAddress)
        {
            COMDriverBoard comDriverBoard = null;
            try
            {
                comDriverBoard = new COMDriverBoard(sCOMPortAddress);
                comDriverBoard.SimulatedPortForDebug = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            return comDriverBoard;
        }

        public void Initialize(bool bArduino)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                if (SimulatedPortForDebug)
                {
                    string msg = String.Format("COMDriverBoard Initialize");
                    MessageBox.Show(msg);
                }
                else
                {
                    m_ComPort = null;

                    m_ComPort = new SerialPort(msCOMPortAddress, 115200, Parity.None, 8, StopBits.One);

                    if (bArduino == false)
                    {
                        // This is critical!! The display driver board expects 0d (carriage return), but .NET defaults to 0a (line feed)
                        // The Arduino, however, uses the .NET default just fine. 
                        m_ComPort.NewLine = "\r";
                    }

                    m_ComPort.ReadTimeout = 8000;
                    m_ComPort.Open();

                    if (bArduino)
                    {
                        // Wait a bit after the immediate connection so that we can ignore initial values.
                        Thread.Sleep(500);

                        // And clear out any values in the buffer. In this case, the arduino code sends along stuff when the microcontroller starts up.
                        m_ComPort.ReadExisting();

                        // Add the event handler only once. 
                        m_ComPort.DataReceived += Port_DataReceived;
                    }


                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = sender as SerialPort;

            // read input
            string incoming = port.ReadExisting();
            // append to serialResponse
            serialResponse += incoming;

        }

        public void ClosePort()
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);


                if (SimulatedPortForDebug)
                {
                    string msg = String.Format("COMDriverBoard ClosePort");
                    MessageBox.Show(msg);
                }
                else
                {
                    if (m_ComPort != null)
                    {
                        if (m_ComPort.IsOpen)
                        {
                            m_ComPort.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }


        public string CalculateColorBits(decimal dutyCyclePct, int iColorCurrent)
        {
            string bitString = "";

            UInt16 dutyCycleBits = Convert.ToUInt16(16383 * (dutyCyclePct / 100));

            for (int i = 0; i < 14; i++)
            {
                if (IsBitSet(dutyCycleBits, i))
                {
                    bitString += "1";
                }
                else
                {
                    bitString += "0";
                }
            }


            switch (iColorCurrent)
            {
                case 1:
                    bitString += "00";
                    break;
                case 3:
                    bitString += "10";
                    break;
                case 10:
                    bitString += "01";
                    break;
                default:
                    bitString += "11";
                    break;
            }


            // Convert the 16 bit value into hex.
            string hexValue = Convert.ToUInt16(bitString, 2).ToString("X4");

            // reverse the string 
            string reversedBitString = ReverseString(bitString);

            return reversedBitString;
        }

        public string ReverseString(string srtVarable)
        {
            return new string(srtVarable.Reverse().ToArray());
        }

        public bool IsBitSet(UInt16 uintVal, int pos)
        {
            return (uintVal & (1 << pos)) != 0;
        }

        public void SendColorValue(LEDColors ledColor, int iByte, int iColorCurrent)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                if (SimulatedPortForDebug)
                {
                    string msg = String.Format("COMDriverBoard SendColorValue {0} {1}", ledColor.ToString(), iByte.ToString());
                    MessageBox.Show(msg);
                }
                else
                {

                    // This was the initial method, which seems to have been in use for a while.
                    // Convert from 0-255 to 0-65535 scale (8 bit to 16 bit).
                    //UInt16 iVal = Convert.ToUInt16(65535 * iByte / 255);

                    // Pretty sure these 2 methods are numerically equivalent. 
                    //UInt16 iVal = (UInt16)((iByte << 8) + iByte);

                    // This was the initial method, which seems to have been in use for a while.
                    // Convert from 0-255 to 0-16383 scale (8 bit to 14 bit).
                    UInt16 iVal = Convert.ToUInt16(16383 * iByte / 255);


                    // We're guessing here (because there is no documentation) that the last 2 bits on the X54(Red) / X55(Green) / X56(Blue) locations set the current. 
                    iVal = SetColorCurrentBits(iVal, 14, iColorCurrent);

                    // Convert the 16 bit value into hex.
                    string hexValue = iVal.ToString("X4");

                    logger.Info("SendColorValue - Address: {0}  Value: {1}", addressDict[ledColor], hexValue);

                    //DialogResult dialogResult = MessageBox.Show(string.Format("Sending {0} to {1}", hexValue, addressDict[ledColor]), "Send to Board", MessageBoxButtons.OKCancel);

                    //if (dialogResult != DialogResult.OK)
                    //{
                    //    return;
                    //}


                    if (m_ComPort == null)
                        this.Initialize(false);

                    if (m_ComPort == null)
                        throw new Exception("Device not found on " + msCOMPortAddress);

                    if (!m_ComPort.IsOpen)
                        m_ComPort.Open();


                    m_ComPort.WriteLine(ADDRESS_UNLOCK);
                    m_ComPort.WriteLine(addressDict[ledColor] + hexValue);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }

        public void SendHexValue(LEDColors ledColor, string sHexValue)
        {
            SendHexValue(addressDict[ledColor], sHexValue);
        }

        public void SendHexValue(string sAddress, string sHexValue)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                if (SimulatedPortForDebug)
                {
                    string msg = String.Format("COMDriverBoard SendHexValue {0} {1}", sAddress, sHexValue);
                    MessageBox.Show(msg);
                }
                else
                {

                    if (m_ComPort == null)
                        this.Initialize(false);

                    if (m_ComPort == null)
                        throw new Exception("Device not found on " + msCOMPortAddress);

                    if (!m_ComPort.IsOpen)
                        m_ComPort.Open();


                    m_ComPort.WriteLine(ADDRESS_UNLOCK);
                    m_ComPort.WriteLine(sAddress + sHexValue);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }

        public void SendHexToX57(string hexValue)
        {
            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                if (SimulatedPortForDebug)
                {
                    string msg = String.Format("COMDriverBoard SendHexToX57 {0}", hexValue);
                    MessageBox.Show(msg);
                }
                else
                {
                    logger.Info("SendHexToX57 - Address: {0}  Value: {1}", ADDRESS_COLOR_CURRENT, hexValue);


                    if (m_ComPort == null)
                        this.Initialize(false);

                    if (m_ComPort == null)
                        throw new Exception("Device not found on " + msCOMPortAddress);

                    if (!m_ComPort.IsOpen)
                        m_ComPort.Open();

                    m_ComPort.WriteLine(ADDRESS_UNLOCK);
                    m_ComPort.WriteLine(ADDRESS_COLOR_CURRENT + hexValue);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

        }

        public static string CalculateX57Hex(int iNumPlaybackSeq, int iRedCurrent, int iBlueCurrent, int iGreenCurrent)
        {
            try
            {
                UInt16 iX57 = UInt16.Parse(iNumPlaybackSeq.ToString());

                iX57 = SetColorCurrentBits(iX57, 8, iRedCurrent);
                iX57 = SetColorCurrentBits(iX57, 10, iBlueCurrent);
                iX57 = SetColorCurrentBits(iX57, 12, iGreenCurrent);

                // Convert the 16 bit value into hex.
                string hexVal = iX57.ToString("X4");

                return hexVal;
            }
            catch (Exception ex)
            {
                return "----";
            }
            finally
            {
            }

        }


        public static UInt16 SetColorCurrentBits(UInt16 uInt16Value, int startingBit, int iColorCurrent)
        {
            UInt16 iNewValue = uInt16Value;

            switch (iColorCurrent)
            {
                case 1:
                    iNewValue = ClearBit(iNewValue, startingBit);
                    iNewValue = ClearBit(iNewValue, startingBit + 1);
                    break;
                case 3:
                    iNewValue = ClearBit(iNewValue, startingBit);
                    iNewValue = SetBit(iNewValue, startingBit + 1);
                    break;
                case 10:
                    iNewValue = SetBit(iNewValue, startingBit);
                    iNewValue = ClearBit(iNewValue, startingBit + 1);
                    break;
                default:
                    iNewValue = SetBit(iNewValue, startingBit);
                    iNewValue = SetBit(iNewValue, startingBit + 1);
                    break;
            }
            return iNewValue;
        }

        public static UInt16 SetBit(int intValue, int bitPosition)
        {
            return (UInt16)(intValue |= 1 << bitPosition);
        }

        public static UInt16 ClearBit(int intValue, int bitPosition)
        {
            return (UInt16)(intValue &= ~(1 << bitPosition));
        }

        public void SetRedOnly(int iRedColorCurrent, int iGreenColorCurrent, int iBlueColorCurrent)
        {
            SendColorValue(LEDColors.Red, 255, iRedColorCurrent);
            SendColorValue(LEDColors.Green, 0, iGreenColorCurrent);
            SendColorValue(LEDColors.Blue, 0, iBlueColorCurrent);
        }
        public void SetGreenOnly(int iRedColorCurrent, int iGreenColorCurrent, int iBlueColorCurrent)
        {
            SendColorValue(LEDColors.Red, 0, iRedColorCurrent);
            SendColorValue(LEDColors.Green, 255, iGreenColorCurrent);
            SendColorValue(LEDColors.Blue, 0, iBlueColorCurrent);
        }
        public void SetBlueOnly(int iRedColorCurrent, int iGreenColorCurrent, int iBlueColorCurrent)
        {
            SendColorValue(LEDColors.Red, 0, iRedColorCurrent);
            SendColorValue(LEDColors.Green, 0, iGreenColorCurrent);
            SendColorValue(LEDColors.Blue, 255, iBlueColorCurrent);
        }

        public void SetAllOff(int iRedColorCurrent, int iGreenColorCurrent, int iBlueColorCurrent)
        {
            SendColorValue(LEDColors.Red, 0, iRedColorCurrent);
            SendColorValue(LEDColors.Green, 0, iGreenColorCurrent);
            SendColorValue(LEDColors.Blue, 0, iBlueColorCurrent);
        }


        public string Read40VfValues()
        {
            string sVfs = "";

            try
            {
                logger.Info("entering {0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);

                if (SimulatedPortForDebug)
                {
                    // 40 values 
                    sVfs = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                }
                else
                {

                    if (m_ComPort == null)
                        this.Initialize(true);

                    if (m_ComPort == null)
                        throw new Exception("Device not found on " + msCOMPortAddress);

                    if (!m_ComPort.IsOpen)
                        m_ComPort.Open();

                    // Clear out any existing responses that we don't care about.
                    m_ComPort.ReadExisting();
                    serialResponse = "";

                    // Send the command to the COM port that should make the Arduino send back the latest 40 Vf measurements.
                    //m_ComPort.WriteLine(READ_VFS);
                    m_ComPort.Write(READ_VFS);

                    // maybe wait a little here?
                    Thread.Sleep(200);

                    //sVfs = m_ComPort.ReadLine();
                    sVfs = serialResponse;

                    logger.Info("sVfs = {0}", sVfs);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            finally
            {
                logger.Info("exiting  {0}.{1}", this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            }

            return sVfs;

        }


    }
}