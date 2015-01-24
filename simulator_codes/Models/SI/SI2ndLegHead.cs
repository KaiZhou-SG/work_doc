using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    public class SI2ndLegHead : MessageHead
    {
        #region "Fields"

        #endregion

        #region "Functions"

        #endregion

        #region "Constructors"
        public SI2ndLegHead() : base()
        {

        }

        public SI2ndLegHead(long msgId, string msgCode,
            string primeMover, string jobNo, string tripSeqNo)
            : base(msgId, msgCode, primeMover, jobNo, tripSeqNo)
        {

        }
        #endregion
    }
}