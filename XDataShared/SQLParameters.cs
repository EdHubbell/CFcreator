using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace XC_Database
{

    public class SQLParameters : Dictionary<string, System.Data.SqlClient.SqlParameter>
    {

        // This ensures that the keys are case insensitive.  If you ask for .Item("SomeCode") or .Item("SOMECODE"), you'll get the same thing.
        public SQLParameters()
            : base(StringComparer.InvariantCultureIgnoreCase)
        {
        }

        public void AddParameter(System.Data.SqlClient.SqlParameter oSqlParameter)
        {

            if (this.ContainsKey(oSqlParameter.ParameterName) == false)
            {
                this.Add(oSqlParameter.ParameterName, oSqlParameter);
            }
            else
            {
                throw new System.Exception("SQL Parameter \"" + oSqlParameter.ParameterName + "\" has already been added.");
            }
        }


        public void AddParameter(string ParameterName, object oValue, System.Data.ParameterDirection ParameterDirection = ParameterDirection.Input)
        {

            System.Data.SqlClient.SqlParameter oSqlParameter = new System.Data.SqlClient.SqlParameter();

            if (this.ContainsKey(ParameterName) == false)
            {
                oSqlParameter.ParameterName = ParameterName;
                oSqlParameter.Value = oValue;
                oSqlParameter.Direction = ParameterDirection;
                this.Add(ParameterName, oSqlParameter);
                // return oSqlParameter;
            }
            else
            {
                throw new System.Exception("SQL Parameter \"" + ParameterName + "\" has already been added.");
            }
        }

        public void AddParameter(string ParameterName, object oValue, System.Data.ParameterDirection ParameterDirection, System.Data.SqlDbType ParameterType, int ParameterSize = 255)
        {

            System.Data.SqlClient.SqlParameter oSqlParameter = new System.Data.SqlClient.SqlParameter();

            if (this.ContainsKey(ParameterName) == false)
            {
                oSqlParameter.ParameterName = ParameterName;
                oSqlParameter.Value = oValue;
                oSqlParameter.SqlDbType = ParameterType;
                if (ParameterType == SqlDbType.VarChar | ParameterType == SqlDbType.NVarChar)
                {
                    oSqlParameter.Size = ParameterSize;
                }
                oSqlParameter.Direction = ParameterDirection;
                this.Add(ParameterName, oSqlParameter);
                //return oSqlParameter;
            }
            else
            {
                throw new System.Exception("SQL Parameter \"" + ParameterName + "\" has already been added.");
            }
        }


        /// <summary>
        /// Add Parameter
        /// </summary>
        public void Add(string ParameterName, object oValue, System.Data.SqlDbType ParameterType, System.Data.ParameterDirection ParameterDirection = ParameterDirection.Input)
        {

            System.Data.SqlClient.SqlParameter oSqlParameter = new System.Data.SqlClient.SqlParameter();

            if (this.ContainsKey(ParameterName) == false)
            {
                oSqlParameter.ParameterName = ParameterName;
                oSqlParameter.Direction = ParameterDirection;
                oSqlParameter.SqlDbType = ParameterType;
                oSqlParameter.Value = oValue;
                this.Add(ParameterName, oSqlParameter);
            }
            else
            {
                throw new System.Exception("SQL Parameter \"" + ParameterName + "\" has already been added.");
            }
        }


        /// <summary>
        /// Add Parameters from this parameters class into the specified command class
        /// </summary>
        public bool AddParametersToSQLCommand(ref System.Data.SqlClient.SqlCommand oSqlCommand, ref string sSQLCommand)
        {
            bool bFirst = true;


            try
            {
                sSQLCommand = string.Empty;

                foreach (System.Data.SqlClient.SqlParameter oSQLParameter in this.Values)
                {
                    oSqlCommand.Parameters.Add(oSQLParameter);
                    if (bFirst == false)
                    {
                        sSQLCommand += "," + System.Environment.NewLine;
                    }
                    bFirst = false;
                    if ((oSQLParameter.DbType == DbType.String) | (oSQLParameter.DbType == DbType.Date) | (oSQLParameter.DbType == DbType.DateTime))
                    {
                        sSQLCommand += "   " + oSQLParameter.ParameterName + "='" + oSQLParameter.Value.ToString() + "'";
                    }
                    else
                    {
                        sSQLCommand += "   " + oSQLParameter.ParameterName + "=" + oSQLParameter.Value.ToString() + "";
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}



