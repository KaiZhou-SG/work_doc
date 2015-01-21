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

        public String ScheduleDate
        {
            get { return strScheduleDate; }
            set { strScheduleDate = value; }
        }
        public String StartTime
        {
            get { return strStartTime; }
            set { strStartTime = value; }
        }

        public String EndTime
        {
            get { return strEndTime; }
            set { strEndTime = value; }
        }

        public String PrimeMover
        {
            get { return strPrimeMover; }
            set { strPrimeMover = value; }
        }

        public String JobNo
        {
            get { return strJobNo; }
            set { strJobNo = value; }
        }

        public String JobSeqNo
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

        public CommonHead(int msgId, MessageType msgType, String strScheduleDate, 
            String strStartTime, String strEndTime, String strPrimeMover, 
            String strJobNo, String strSeqNo) : base(msgId, msgType)
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
            MessageType msgType = new MessageType(strMsgCode, strMsgTypeCode,
                strMsgTypeDescription);

            new CommonHead(msgId, msgType, strScheduleDate, strStartTime, strEndTime,
                strPrimeMover, strJobNo, strSeqNo);
            
        }

        #endregion

    }
}