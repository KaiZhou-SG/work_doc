using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.Models;
using FM.FMSystem.BLL;
using FM.FMSystem.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MS_Simulator.Models.Basement;

namespace MS_Simulator.DAL
{
    public class MessageDAL
    {
        public static long GetNextMessageId(String msgTypeCode)
        {
            // get the maximum message id depending on the message type
            long lMaximumMsgId = 0L;
            String strQuery = String.Empty;
            if (msgTypeCode == MessageCodesEnum.COL.ToString())
            {
                lMaximumMsgId = GetNextMessageIdOfSE1stLeg();
            }
            else if (msgTypeCode == MessageCodesEnum.EXP.ToString())
            {
                lMaximumMsgId = GetNextMessageIdOfSE2ndLeg();
            }
                
            return lMaximumMsgId + 1;
        }

        public static long GetNextMessageIdOfSE1stLeg()
        {
            long lMaximumMsgId = 0L;
            String strQuery = String.Empty;
            String strDbCon = FMGlobalSettings.TheInstance.getConnectionString();
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    // SE 1st Leg
                    strQuery = "SELECT MAX(Msg_Id) FROM MS_SE1stLeg_Register_Head_Tbl";
                    SqlCommand dbCmd = new SqlCommand(strQuery, dbCon);
                    lMaximumMsgId = dbCmd.ExecuteScalar() == DBNull.Value ? 0 :
                        Convert.ToInt32(dbCmd.ExecuteScalar());
                }
                catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
                catch (InvalidCastException ice) { throw new FMException(ice.Message); }
                catch (SqlException se) { throw new FMException(se.Message); }
                catch (ConfigurationException ce) { throw new FMException(ce.Message); }
                catch (Exception e) { throw new FMException(e.Message); }
            }

            return lMaximumMsgId + 1;
        }

        public static long GetNextMessageIdOfSE2ndLeg()
        {
            long lMaximumMsgId = 0L;
            String strQuery = String.Empty;
            String strDbCon = FMGlobalSettings.TheInstance.getConnectionString();
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    // SE 1st Leg
                    strQuery = "SELECT MAX(Msg_Id) FROM MS_SE2ndLeg_Register_Head_Tbl";
                    SqlCommand dbCmd = new SqlCommand(strQuery, dbCon);
                    lMaximumMsgId = dbCmd.ExecuteScalar() == DBNull.Value ? 0 :
                        Convert.ToInt32(dbCmd.ExecuteScalar());
                }
                catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
                catch (InvalidCastException ice) { throw new FMException(ice.Message); }
                catch (SqlException se) { throw new FMException(se.Message); }
                catch (ConfigurationException ce) { throw new FMException(ce.Message); }
                catch (Exception e) { throw new FMException(e.Message); }
            }

            return lMaximumMsgId + 1;
        }

    }
}