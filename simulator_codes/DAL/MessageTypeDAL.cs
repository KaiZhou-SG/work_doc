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

namespace MS_Simulator.DAL
{
    public class MessageTypeDAL
    {
        #region "Functions"
        /// <summary>
        /// Add a new message type with a different message code.
        /// </summary>
        /// <param name="msgType">The new message type object</param>
        /// <returns></returns>
        public static MessageType AddMessageType(MessageType msgType)
        {
            MessageType rtnMsgType = new MessageType();
            String strDbCon = FMGlobalSettings.TheInstance.getConnectionString();

            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            {
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    SqlTransaction dbTran = dbCon.BeginTransaction();
                    rtnMsgType = AddMessageType(msgType, dbCon, dbTran);

                    dbTran.Commit(); // commit transaction only from where it is started
                }
                catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
                catch (Exception e) { throw new FMException(e.Message); }

            }

            return rtnMsgType;
        }

        public static MessageType AddMessageType(MessageType msgType, SqlConnection dbCon,
            SqlTransaction dbTran)
        {
            MessageType rtnMsgType = new MessageType();
            String strQuery = "INSERT INTO MS_Message_Types_Tbl(Msg_Code, Msg_Type_Code, "
                + " Msg_Type_Description) VALUES ('{0}', '{1}', '{2}')";
            strQuery = String.Format(strQuery, msgType.Msg_Code, msgType.Msg_Type_Code,
                msgType.Msg_Type_Description);

            try
            {
                using (SqlCommand dbCmd = new SqlCommand(strQuery, dbCon))
                {
                    dbCmd.Transaction = dbTran;
                    dbCmd.ExecuteNonQuery(); // don't commit transaction here
                }
            }
            catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
            catch (InvalidCastException ice) { throw new FMException(ice.Message); }
            catch (SqlException se) { throw new FMException(se.Message); }
            catch (ConfigurationException ce) { throw new FMException(ce.Message); }
            catch (Exception e) { throw new FMException(e.Message); }

            return new MessageType();
        }

        #endregion
    }
}