using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using System.Data;
using System.Data.SqlClient;
using MS_Simulator.Models;
using FM.FMSystem.BLL;
using FM.FMSystem.DAL;
using System.Configuration;

namespace MS_Simulator.DAL
{
    public class MsgSE1stLegRegMessageDAL
    {
        public static TheMessage RegisterSE1stLeg(TheMessage msg)
        {
            String strDbCon = FMGlobalSettings.TheInstance.getConnectionString();
            using (SqlConnection dbCon = new SqlConnection(strDbCon))
            {
                // start a sql transaction here to insert both message head and body
                try
                {
                    if (dbCon.State == ConnectionState.Closed) { dbCon.Open(); }
                    {
                        SqlTransaction dbTran = dbCon.BeginTransaction();
                        long lMsgId = InsertSE1stLegHead(msg.MsgHead, dbCon, dbTran);
                        InsertSE1stLegBody(lMsgId, msg.MsgBody, dbCon, dbTran);

                        dbTran.Commit();
                        // msg.MsgHead.
                        msg.MsgHead.MsgId = lMsgId;
                        return msg;
                    }
                }
                catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
                catch (InvalidCastException ice) { throw new FMException(ice.Message); }
                catch (SqlException se) { throw new FMException(se.Message); }
                catch (ConfigurationException ce) { throw new FMException(ce.Message); }
                catch (Exception e) { throw new FMException(e.Message); }
            }

        }

        public static long InsertSE1stLegHead(MsgSE1stLegHead msgHead, 
            SqlConnection dbCon, SqlTransaction dbTran)
        {
            long msgId = MessageDAL.GetNextMessageId(msgHead.MsgType.Msg_Type_Code);
            String strDbCon = FMGlobalSettings.TheInstance.getConnectionString();

            String strQuery = "INSERT INTO MS_SE1stLeg_Register_Head_Tbl(" +
                "(Msg_Id, Msg_Code, Schedule_Date, Start_Time, End_Time, " +
                "Prime_Mover, Job_Number, Job_Trip_SeqNo) VALUES " +
                "({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";
            strQuery = String.Format(strQuery, msgId, msgHead.MsgType.Msg_Type_Code,
                msgHead.StartTime, msgHead.EndTime, msgHead.PrimeMover, 
                msgHead.JobNo, msgHead.JobSeqNo);
            try
            {
                using (SqlCommand dbCmd = new SqlCommand(strQuery, dbCon))
                {
                    dbCmd.Transaction = dbTran;
                    dbCmd.ExecuteNonQuery();
                }
            }
            catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
            catch (InvalidCastException ice) { throw new FMException(ice.Message); }
            catch (SqlException se) { throw new FMException(se.Message); }
            catch (ConfigurationException ce) { throw new FMException(ce.Message); }
            catch (Exception e) { throw new FMException(e.Message); }

            return msgId;
        }

        public static bool InsertSE1stLegBody(long msgId, MsgSE1stLegBody msgBody, 
            SqlConnection dbCon, SqlTransaction dbTran)
        {
            bool rtn = false;
            String strDbCon = FMGlobalSettings.TheInstance.getConnectionString();

            String strQuery = "INSERT INTO MS_SE1stLeg_Register_Body_Tbl(" +
                "(Msg_Id, Vessel, Voyage, BookRefNo, ShippingLine, " +
                "POD, Container_Qty, Container_Size, Container_Type, " +
                " ) VALUES " +
                "({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', " +
                " '{8}', '{9}', '{10}', '{11}')";
            strQuery = String.Format(strQuery, msgId, msgBody.Vessel, msgBody.Voyage,
                msgBody.BookRefNo, msgBody.ShippingLine, msgBody.POD, 
                msgBody.ContainerQty, msgBody.ContainerSize, msgBody.FromLocation,
                msgBody.ToLocation, msgBody.Remark);
            try
            {
                using (SqlCommand dbCmd = new SqlCommand(strQuery, dbCon))
                {
                    dbCmd.Transaction = dbTran;
                    dbCmd.ExecuteNonQuery();
                }
            }
            catch (InvalidOperationException ioe) { throw new FMException(ioe.Message); }
            catch (InvalidCastException ice) { throw new FMException(ice.Message); }
            catch (SqlException se) { throw new FMException(se.Message); }
            catch (ConfigurationException ce) { throw new FMException(ce.Message); }
            catch (Exception e) { throw new FMException(e.Message); }

            return rtn;
        }
    }
}