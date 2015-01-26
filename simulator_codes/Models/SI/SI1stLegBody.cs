using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.Models.Basement;

namespace MS_Simulator.Models.SI
{
    public class SI1stLegBody : FirstLegBody, ISelfCheckable
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
        public SI1stLegBody() : base()
        {

        }

        public SI1stLegBody(long msgId, string scheduleDate, string startTime, string endTime,
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