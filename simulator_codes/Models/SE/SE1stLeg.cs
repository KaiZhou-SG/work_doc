using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.Models.Basement;
using FM.FMSystem.BLL;

namespace MS_Simulator.Models.SE
{
    public class SE1stLeg : ISelfCheckable
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
            // check if the message code corresponds to the correct message type code:
            if (MessageType.MSG_CODE_TO_TYPE_CODE[this.Head.MsgCode] !=
                this.Body.MsgTypeCode)
            {
                throw new FM.FMSystem.BLL.FMException("Message code " +
                    "does not match to message type code. " +
                    "MessageId: " + this.Head.MsgId + " Message type code: " + 
                    this.Body.MsgTypeCode);
            }

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

            // do a self check first
            SelfCheck();
  
        }

        #endregion
    }
}