using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// MessageHead.cs
    /// The common message head, inherited by a few other message heads
    /// </summary>
    public class MessageHead
    {
        #region "Fields"
        private long msgId;
        private string msgCode;
        private string primeMover;
        private string jobNo;
        private string tripSeqNo;

        public long MsgId
        {
            get { return msgId; }
            set { msgId = value; }
        }
        public string MsgCode
        {
            get { return msgCode; }
            set { msgCode = value; }
        }
        public string PrimeMover
        {
            get { return primeMover; }
            set { primeMover = value; }
        }
        public string JobNo
        {
            get { return jobNo; }
            set { jobNo = value; }
        }
        public string TripSeqNo
        {
            get { return tripSeqNo; }
            set { tripSeqNo = value; }
        }

        #endregion 

        #region "Functions"
        public bool SelfCheck()
        {
            // rules to be added:

            return true;
        }
        #endregion

        #region "Constructors"
        public MessageHead()
        {

        }

        public MessageHead(long msgId, string msgCode, string primeMover,
            string jobNo, string tripSeqNo)
        {
            this.msgId = msgId;
            this.msgCode = msgCode;
            this.primeMover = primeMover;
            this.jobNo = jobNo;
            this.tripSeqNo = tripSeqNo;
        }
        #endregion
    }
}