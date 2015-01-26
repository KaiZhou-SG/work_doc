using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.Models.Basement;

namespace MS_Simulator.Models.SI
{
    public class SI1stLeg : ISelfCheckable
    {
        #region "Fields"
        private SI1stLegHead head;
        private SI1stLegBody body;
        public SI1stLegHead Head
        {
            get { return head; }
            set { head = value; }
        }
        public SI1stLegBody Body
        {
            get { return body; }
            set { body = value; }
        }

        #endregion

        #region "Functions"
        public bool SelfCheck()
        {
            // add rules here

            return true;
        }

        #endregion

        #region "Constructors"
        public SI1stLeg()
        {

        }

        public SI1stLeg(SI1stLegHead head, SI1stLegBody body)
        {
            this.head = head;
            this.body = body;
        }

        #endregion
    }
}