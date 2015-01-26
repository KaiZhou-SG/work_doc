using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models.Basement
{
    /// <summary>
    /// MsgLogger.cs
    /// This class is used to log all sent / received
    /// messages throughout the Simulator.
    /// </summary>
    public class MsgLogger
    {
        #region "Fields"
        private string msgCode;
        private long msgId;
        private string sentDate;
        private string sentTime;
        private string receivedDate;
        private string receivedTime;
        private string sentBy;
        private string receivedBy;

        public string MsgCode
        {
            get { return msgCode; }
            set { msgCode = value; }
        }
        public long MsgId
        {
            get { return msgId; }
            set { msgId = value; }
        }
        public string SentDate
        {
            get { return sentDate; }
            set { sentDate = value; }
        }
        public string SentTime
        {
            get { return sentTime; }
            set { sentTime = value; }
        }
        public string ReceivedDate
        {
            get { return receivedDate; }
            set { receivedDate = value; }
        }
        public string ReceivedTime
        {
            get { return receivedTime; }
            set { receivedTime = value; }
        }

        #endregion

        #region "Functions"
        public string WriteLog(MsgLogger log)
        {
            throw new NotImplementedException();
        }

        public List<MsgLogger> SearchLog()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region "Constructors"
        public MsgLogger()
        {

        }

        public MsgLogger(string msgCode, long msgId,
            string sentDate, string sentTime, string receivedDate,
            string receivedTime, string sentBy, string receivedBy)
        {
            this.msgCode = msgCode;
            this.msgId = msgId;
            this.sentDate = sentDate;
            this.sentTime = sentTime;
            this.receivedDate = receivedDate;
            this.receivedTime = receivedTime;
            this.sentBy = sentBy;
            this.receivedBy = receivedBy;
        }

        #endregion

    }
}