using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.Models.Basement;

namespace MS_Simulator.Models.SE
{
    public class SE2ndLegBody : SecondLegBody, ISelfCheckable
    {
        #region "Fields"

        #endregion

        #region "Functions"
        public override bool SelfCheck()
        {
            // add rules here

            return base.SelfCheck();
        }
        #endregion

        #region "Constructors"
        public SE2ndLegBody() : base()
        {

        }

        public SE2ndLegBody(long msgId, string scheduleDate, string startTime,
            string endTime, string msgTypeCode, int containerQty,
            string containerSize, string containerType,
            string fromLocation, string toLocation, string remark) : 
            base(msgId, scheduleDate, startTime, endTime, msgTypeCode,
                containerQty, containerSize, containerType,
                fromLocation, toLocation, remark)
        {

        }
        #endregion
    }
}