using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models.Basement
{
    /// <summary>
    /// SecondLegBody.cs
    /// The message body of the second leg, for either SE or SI
    /// </summary>
    public class SecondLegBody
    {
        #region "Fields"
        private long msgId;
        private string scheduleDate;
        private string startTime;
        private string endTime;
        private string msgTypeCode;
        private int containerQty;
        private string containerSize; // can only be 20, 40 or 45
        private string containerType;
        private string fromLocation;
        private string toLocation;
        private string remark;

        public long MsgId
        {
            get { return msgId; }
            set { msgId = value; }
        }
        public string ScheduleDate
        {
            get { return scheduleDate; }
            set { scheduleDate = value; }
        }
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public string MsgTypeCode
        {
            get { return msgTypeCode; }
            set { msgTypeCode = value; }
        }
        public int ContainerQty
        {
            get { return containerQty; }
            set { containerQty = value; }
        }
        public string ContainerSize
        {
            get { return containerSize; }
            set { containerSize = value; }
        }
        public string ContainerType
        {
            get { return containerType; }
            set { containerType = value; }
        }
        public string FromLocation
        {
            get { return fromLocation; }
            set { fromLocation = value; }
        }
        public string ToLocation
        {
            get { return toLocation; }
            set { toLocation = value; }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        #endregion

        #region "Functions"
        public virtual bool SelfCheck()
        {
            // add rules here:

            return true;
        }
        #endregion

        #region "Constructors"
        public SecondLegBody()
        {

        }

        public SecondLegBody(long msgId, string scheduleDate, string startTime, 
            string endTime, string msgTypeCode, int containerQty, 
            string containerSize, string containerType, string fromLocation,
            string toLocation, string remark)
        {
            this.msgId = msgId;
            this.scheduleDate = scheduleDate;
            this.startTime = startTime;
            this.endTime = endTime;
            this.msgTypeCode = msgTypeCode;
            this.containerQty = containerQty;
            this.containerSize = containerSize;
            this.containerType = containerType;
            this.fromLocation = fromLocation;
            this.toLocation = toLocation;
            this.remark = remark;
        }

        #endregion
    }
}