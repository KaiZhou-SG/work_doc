﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    public class SE2ndLegHead : MessageHead
    {
        #region "Fields"

        #endregion

        #region "Functions"

        #endregion

        #region "Constructors"
        public SE2ndLegHead() : base()
        {

        }

        public SE2ndLegHead(long msgId, string msgCode,
            string primeMover, string jobNo, string tripSeqNo)
            : base(msgId, msgCode, primeMover, jobNo, tripSeqNo)
        {

        }
        #endregion
    }
}