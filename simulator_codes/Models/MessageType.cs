using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.DAL;
using System.Data.SqlClient;

namespace MS_Simulator.Models
{
    public class MessageType
    {
        #region "Fields"
        private String strMsg_Code;
        private String strMsg_Type_Code;
        private String strMsg_Type_Description;

        public String Msg_Code
        {
            get { return strMsg_Code; }
            set { strMsg_Code = value; }
        }

        public String Msg_Type_Code
        {
            get { return strMsg_Type_Code; }
            set { strMsg_Type_Code = value; }
        }

        public String Msg_Type_Description
        {
            get { return strMsg_Type_Description; }
            set { strMsg_Type_Description = value; }
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

        #endregion

        #region "Constructors"
        public MessageType()
        {
            this.strMsg_Code = "00";
            this.strMsg_Type_Code = "Default_Msg_Type";
            this.strMsg_Type_Description = "Default_Description";

        }

        public MessageType(String msgCode, String msgTypeCode,
            String msgTypeDescription)
        {
            this.strMsg_Code = msgCode;
            this.strMsg_Type_Code = msgTypeCode;
            this.strMsg_Type_Description = msgTypeDescription;

        }

        #endregion
        
    }
}