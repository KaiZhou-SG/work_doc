using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// SE1stLegHead.cs
    /// The message head of the registering message of the sea-export 1st leg.
    /// </summary>
    public class SE1stLegHead : MessageHead
    {
        #region "Fields"

        #endregion

        #region "Functions"

        #endregion

        #region "Constructors"
        public SE1stLegHead() : base()
        {

        }

        public SE1stLegHead(long msgId, string msgCode,
            string primeMover, string jobNo, string tripSeqNo)
            : base(msgId, msgCode, primeMover, jobNo, tripSeqNo)
        {

        }
        #endregion

    }
}