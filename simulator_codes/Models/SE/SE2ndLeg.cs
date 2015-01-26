using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.Models.Basement;

namespace MS_Simulator.Models.SE
{
    public class SE2ndLeg : ISelfCheckable
    {
        #region "Fields"
        private SE2ndLegHead head;
        private SE2ndLegBody body;
        public SE2ndLegHead Head
        {
            get { return head; }
            set { head = value; }
        }
        public SE2ndLegBody Body
        {
            get { return body; }
            set { body = value; }
        }

        #endregion

        #region "Functions"
        public bool SelfCheck()
        {
            // add rules here:

            return true;
        }

        #endregion

        #region "Constructors"

        #endregion
    }
}