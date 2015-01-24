using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SE1stLegBody : FirstLegBody
    {
        #region "Fields"

        #endregion

        #region "Functions"
        public override bool SelfCheck()
        {
            return base.SelfCheck();
        }
        #endregion 

        #region "Constructors"
        public SE1stLegBody() : base()
        {

        }

        public SE1stLegBody(long msgId, string scheduleDate, string startTime, string endTime,
            string msgTypeCode, string vessel, string voyage, string bookRefNo, 
            string shippingLine, string pod,
            int containerQty, string containerSize,
            string containerType, string fromLocation, string toLocation,
            string remark) : base(msgId, scheduleDate, startTime, endTime, msgTypeCode,
                vessel, voyage, bookRefNo, shippingLine, pod, 
                containerQty, containerSize, containerType, fromLocation,
                toLocation, remark)
        {

        }

        #endregion 
    }
}