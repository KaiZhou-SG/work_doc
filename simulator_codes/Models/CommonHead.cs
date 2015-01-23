using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// CommonHead.cs
    /// The common message header.
    /// </summary>
    [Serializable()]
    public class CommonHead : MessageHead
    {
        #region "Fields"
        // private MessageHead messageHead; // including msgCode, msgTypeCode
        private String strScheduleDate;
        private String strStartTime;
        private String strEndTime;
        private String strPrimeMover;
        private String strJobNo;
        private String strSeqNo;

        public string ScheduleDate
        {
            get { return strScheduleDate; }
            set { strScheduleDate = value; }
        }
        public string StartTime
        {
            get { return strStartTime; }
            set { strStartTime = value; }
        }

        public string EndTime
        {
            get { return strEndTime; }
            set { strEndTime = value; }
        }

        public string PrimeMover
        {
            get { return strPrimeMover; }
            set { strPrimeMover = value; }
        }

        public string JobNo
        {
            get { return strJobNo; }
            set { strJobNo = value; }
        }

        public string JobSeqNo
        {
            get { return strJobNo; }
            set { strJobNo = value; }
        }

        #endregion

        #region "Functions"
        public override bool GeneralSelfCheck()
        {
            // will add extra rules in future here.
            if (strScheduleDate.Length != 10 ||
                strStartTime.Length != 4 ||
                strEndTime.Length != 4)
            {
                return false;
            }

            return true;
        }

        #endregion

        #region "Constructors"
        public CommonHead() : base()
        {

        }

        public CommonHead(int msgId, MessageType msgType, string strScheduleDate, 
            string strStartTime, string strEndTime, string strPrimeMover, 
            string strJobNo, string strSeqNo) : base(msgId, msgType)
        {
            this.strScheduleDate = strScheduleDate;
            this.strStartTime = strStartTime;
            this.strEndTime = strEndTime;
            this.strPrimeMover = strPrimeMover;
            this.strJobNo = strJobNo;
            this.strSeqNo = strSeqNo;
        }

        public CommonHead(int msgId, String strMsgCode, String strMsgTypeCode, 
            String strMsgTypeDescription, String strScheduleDate,
            String strStartTime, String strEndTime, String strPrimeMover,
            String strJobNo, String strSeqNo) : 
                base(msgId, strMsgCode, strMsgTypeCode, strMsgTypeDescription)
        {
            this.strScheduleDate = strScheduleDate;
            this.strStartTime = strStartTime;
            this.strEndTime = strEndTime;
            this.strPrimeMover = strPrimeMover;
            this.strJobNo = strJobNo;
            this.strSeqNo = strSeqNo;

        }

        #endregion

    }
}