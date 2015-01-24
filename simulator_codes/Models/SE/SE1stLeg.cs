using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models.SE
{
    public class SE1stLeg
    {
        #region "Fields"
        private SE1stLegHead head;
        private SE1stLegBody body;
        public SE1stLegHead Head
        {
            get { return head; }
            set { head = value; }
        }
        public SE1stLegBody Body
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
        public SE1stLeg()
        {

        }

        public SE1stLeg(SE1stLegHead head, SE1stLegBody body)
        {
            this.head = head;
            this.body = body;
        }

        #endregion
    }
}