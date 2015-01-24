using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// FirstLegBody.cs
    /// The message body of the 1st leg, for either SE or SI
    /// </summary>
    public class FirstLegBody
    {
        #region "Fields"
        private long msgId;
        private string scheduleDate;
        private string startTime;
        private string endTime;
        private string msgTypeCode; // e.g., COL, RTN, EXP, IMP, ACK
        private string vessel;
        private string voyage;
        private string bookRefNo;
        private string shippingLine;
        private string pod;
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
        public string Vessel
        {
            get { return vessel; }
            set { vessel = value; }
        }
        public string Voyage
        {
            get { return voyage; }
            set { voyage = value; }
        }
        public string BookRefNo
        {
            get { return bookRefNo; }
            set { bookRefNo = value; }
        }

        public string ShippingLine
        {
            get { return shippingLine; }
            set { shippingLine = value; }
        }

        public string POD
        {
            get { return pod; }
            set { pod = value; }
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
        public FirstLegBody()
        {

        }

        public FirstLegBody(long msgId, string scheduleDate, string tripStartTime, string tripEndTime,
            string msgTypeCode, string vessel, string voyage, string bookRefNo,
            string shippingLine, string pod, int containerQty, string containerSize,
            string containerType, string fromLocation, string toLocation, string remark)
        {
            this.msgId = msgId;
            this.scheduleDate = scheduleDate;
            this.startTime = tripStartTime;
            this.endTime = tripEndTime;
            this.msgTypeCode = msgTypeCode;
            this.vessel = vessel;
            this.voyage = voyage;
            this.bookRefNo = bookRefNo;
            this.shippingLine = shippingLine;
            this.pod = pod;
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