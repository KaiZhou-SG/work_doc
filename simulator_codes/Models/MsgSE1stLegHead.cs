using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// MsgSE1stLegHead.cs
    /// represents the header of the Sea-Export 1st registering message: head of Msg1
    /// </summary>
    public class MsgSE1stLegHead : CommonHead
    {
        #region "Fields"
        // no other fields than those of the common header yet

        #endregion

        #region "Functions"
        // no new functions so far

        #endregion

        #region "Constructors"
        public MsgSE1stLegHead() : base()
        {
            
        }

        public MsgSE1stLegHead(int msgId, MessageType msgType, String scheduleDate,
            String startTime, String endTime, String primeMover, String jobNo,
            String jobTripSeqNo) : base(msgId, msgType, scheduleDate, startTime, endTime,
                primeMover, jobNo, jobTripSeqNo)
        {
            // no extra fields needed to be initialized

        }

        #endregion

    }
}