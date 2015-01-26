using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.DAL;
using System.Data.SqlClient;

namespace MS_Simulator.Models.Basement
{
    [Serializable()]
    public class MessageType
    {
        #region "Fields"
        private String msg_Code;
        private String msg_Type_Code;
        private String msg_Type_Description;
        public static Dictionary<string, string> MSG_CODE_TO_TYPE_CODE;

        public string Msg_Code
        {
            get { return msg_Code; }
            set { msg_Code = value; }
        }

        public string Msg_Type_Code
        {
            get { return msg_Type_Code; }
            set { msg_Type_Code = value; }
        }

        public string Msg_Type_Description
        {
            get { return msg_Type_Description; }
            set { msg_Type_Description = value; }
        }

        #endregion

        #region "Functions"
        public MessageType AddMessageType(MessageType msgType)
        {
            return MessageTypeDAL.AddMessageType(msgType);
        }

        public MessageType AddMessageType(MessageType msgType, SqlConnection dbCon,
            SqlTransaction dbTran)
        {
            return MessageTypeDAL.AddMessageType(msgType, dbCon, dbTran);
        }

        public static void IniMessageCodeToTypeCodeMapping()
        {
            MessageTypeDAL.IniMessageCodeToTypeCodeMapping();

            return;
        }

        #endregion

        #region "Constructors"
        public MessageType()
        {
            this.msg_Code = "00";
            this.msg_Type_Code = "Default_Msg_Type";
            this.msg_Type_Description = "Default_Description";

        }

        public MessageType(String msgCode, String msgTypeCode,
            String msgTypeDescription)
        {
            this.msg_Code = msgCode;
            this.msg_Type_Code = msgTypeCode;
            this.msg_Type_Description = msgTypeDescription;

        }

        #endregion
        
    }
}