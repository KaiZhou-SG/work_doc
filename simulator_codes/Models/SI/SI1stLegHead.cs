using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    public class SI1stLegHead : MessageHead
    {
        #region "Fields"

        #endregion

        #region "Functions"

        #endregion

        #region "Constructors"
        public SI1stLegHead() : base()
        {

        }

        public SI1stLegHead(long msgId, string msgCode,
            string primeMover, string jobNo, string tripSeqNo)
            : base(msgId, msgCode, primeMover, jobNo, tripSeqNo)
        {

        }
        #endregion
    }
}