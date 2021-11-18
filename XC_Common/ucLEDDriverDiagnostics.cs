using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XC_Common;
using NLog;

namespace XC_Common
{
    public partial class ucLEDDriverDiagnostics : UserControl
    {
        private COMDriverBoard _COMDriverBoard;

        private bool bInitComplete = false;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ucLEDDriverDiagnostics()
        {
            InitializeComponent();
        }

        public void SetComDriverBoard(COMDriverBoard oCOMDriverBoard)
        {
            _COMDriverBoard = oCOMDriverBoard;
        }

        private void BtnInitDriver_Click(object sender, EventArgs e)
        {
            _COMDriverBoard.Initialize(false);
            btnInitDriver.Enabled = false;
        }

        private void BtnSetRedOnly_Click(object sender, EventArgs e)
        {
            ipRedPct.Value = 100;
            ipGreen.Value = 0;
            ipBlue.Value = 0;
            cboRedCurrent.SelectedIndex = 3;
            cboGreenCurrent.SelectedIndex = 0;
            cboBlueCurrent.SelectedIndex = 0;
            _COMDriverBoard.SetRedOnly(int.Parse(cboRedCurrent.Text), int.Parse(cboGreenCurrent.Text), int.Parse(cboBlueCurrent.Text));
        }

        private void BtnSetGreenOnly_Click(object sender, EventArgs e)
        {
            ipRedPct.Value = 0;
            ipGreen.Value = 100;
            ipBlue.Value = 0;
            cboRedCurrent.SelectedIndex = 0;
            cboGreenCurrent.SelectedIndex = 3;
            cboBlueCurrent.SelectedIndex = 0;
            _COMDriverBoard.SetGreenOnly(int.Parse(cboRedCurrent.Text), int.Parse(cboGreenCurrent.Text), int.Parse(cboBlueCurrent.Text));
        }

        private void BtnSetBlueOnly_Click(object sender, EventArgs e)
        {
            ipRedPct.Value = 0;
            ipGreen.Value = 0;
            ipBlue.Value = 100;
            cboRedCurrent.SelectedIndex = 0;
            cboGreenCurrent.SelectedIndex = 0;
            cboBlueCurrent.SelectedIndex = 3;
            _COMDriverBoard.SetBlueOnly(int.Parse(cboRedCurrent.Text), int.Parse(cboGreenCurrent.Text), int.Parse(cboBlueCurrent.Text));
        }

        private void BtnSetRed_Click(object sender, EventArgs e)
        {
            _COMDriverBoard.SendHexValue(COMDriverBoard.LEDColors.Red, txtHexRed.Text);
        }

        private void BtnSetGreen_Click(object sender, EventArgs e)
        {
            _COMDriverBoard.SendHexValue(COMDriverBoard.LEDColors.Green, txtHexGreen.Text);
            //_COMDriverBoard.SendColorValue(COMDriverBoard.LEDColors.Green, (Byte)ipGreen.Value, int.Parse(cboGreenCurrent.Text));
        }

        private void BtnSetBlue_Click(object sender, EventArgs e)
        {
            _COMDriverBoard.SendHexValue(COMDriverBoard.LEDColors.Blue, txtHexBlue.Text);
            //_COMDriverBoard.SendColorValue(COMDriverBoard.LEDColors.Blue, (Byte)ipBlue.Value, int.Parse(cboBlueCurrent.Text));
        }

        private void ucLEDDriverDiagnostics_Load(object sender, EventArgs e)
        {
            // set the default values for the dropdowns. 
            cboRedCurrent.SelectedIndex = 0;
            cboBlueCurrent.SelectedIndex = 0;
            cboGreenCurrent.SelectedIndex = 0;

            bInitComplete = true;
        }

        private void btnSendHexValue_Click(object sender, EventArgs e)
        {
            _COMDriverBoard.SendHexValue(cboRawHexAddress.SelectedItem.ToString(), txtRawHexValue.Text);
        }

        private void txtBinaryIn_TextChanged(object sender, EventArgs e)
        {
            if (txtBinaryIn.Text.Length == 16)
            {
                try
                {
                    string strHex = Convert.ToUInt16(txtBinaryIn.Text, 2).ToString("X4");
                    txtHexOut.Text = strHex;
                }
                catch (Exception ex)
                {
                    logger.Error(ex);
                }
            }
            else
            {
                txtHexOut.Text = string.Format("<{0}>", 16 - txtBinaryIn.Text.Length);
            }
        }

        private void txtHexIn_TextChanged(object sender, EventArgs e)
        {
            if (txtHexIn.Text.Length == 4)
            {
                try
                {
                    string strBinary = Convert.ToString(Convert.ToUInt16(txtHexIn.Text, 16), 2);
                    txtBinaryOut.Text = strBinary;
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                txtBinaryOut.Text = string.Format("<{0}>", 4 - txtHexIn.Text.Length);
            }

        }


        private void SetRedBits()
        {
            try
            {
                if (bInitComplete != true) return;

                txtBitsRed.Text = _COMDriverBoard.CalculateColorBits(ipRedPct.Value, int.Parse(cboRedCurrent.Text));
                txtHexRed.Text = Convert.ToUInt16(txtBitsRed.Text, 2).ToString("X4");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ipRedPct_ValueChanged(object sender, EventArgs e)
        {
            SetRedBits();
        }

        private void cboRedCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRedBits();
        }

        private void SetGreenBits()
        {
            try
            {
                if (bInitComplete != true) return;

                txtBitsGreen.Text = _COMDriverBoard.CalculateColorBits(ipGreen.Value, int.Parse(cboGreenCurrent.Text));
                txtHexGreen.Text = Convert.ToUInt16(txtBitsGreen.Text, 2).ToString("X4");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ipGreen_ValueChanged(object sender, EventArgs e)
        {
            SetGreenBits();
        }

        private void cboGreenCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetGreenBits();
        }

        private void SetBlueBits()
        {
            try
            {
                if (bInitComplete != true) return;

                txtBitsBlue.Text = _COMDriverBoard.CalculateColorBits(ipBlue.Value, int.Parse(cboBlueCurrent.Text));
                txtHexBlue.Text = Convert.ToUInt16(txtBitsBlue.Text, 2).ToString("X4");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        private void ipBlue_ValueChanged(object sender, EventArgs e)
        {
            SetBlueBits();
        }

        private void cboBlueCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBlueBits();
        }

        private void btnInitArduinoDriver_Click(object sender, EventArgs e)
        {
            _COMDriverBoard.Initialize(true);
            btnInitArduinoDriver.Enabled = false;
        }

        private void btnReadVfs_Click(object sender, EventArgs e)
        {
            txtVfs.Text = _COMDriverBoard.Read40VfValues();

            //try
            //{
            //    List<double> listVfs = null;

            //    //if (_COMDriverBoard == null)
            //    //{
            //    //    COMDriverBoard _COMDriverBoard = new COMDriverBoard("COM4");
            //    //}

            //    listVfs = new List<double>();
            //    string sVfs = _COMDriverBoard.Read40VfValues();
            //    logger.Info("TrueTest Vfs - {0}", sVfs);
            //    listVfs = sVfs.Split(',').Select(double.Parse).ToList();


            //    //txtVfs.Text = "";

            //    //List<Double> listVfs = new List<double>();
            //    //string sVfs = _COMDriverBoard.Read40VfValues();
            //    //listVfs = sVfs.Split(',').Select(double.Parse).ToList();

            //    txtVfs.Text = "";
            //    for (int i = 0; i < 40; i++)
            //    {
            //        txtVfs.Text += listVfs[i].ToString();
            //        txtVfs.Text += " ";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    logger.Error(ex);
            //}

        }
    }
}
