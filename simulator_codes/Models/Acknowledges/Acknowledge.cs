using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MS_Simulator.Models.Basement;

namespace MS_Simulator.Models.Acknowledges
{
    public class Acknowledge : MessageType
    {
        #region "Fields"
        private long msgId;
        public long MsgId
        {
            get { return msgId; }
            set { msgId = value; }
        }

        #endregion

        #region "Functions"

        #endregion

        #region "Constructors"
        public Acknowledge() : base()
        {

        }

        public Acknowledge(long msgId, string msgCode, 
            string msgTypeCode, string msgTypeDescription) : 
            base(msgCode, msgTypeCode, msgTypeDescription)
        {
            this.msgId = msgId;
            // notice that, the msgCode, msgTypeCode,
            // msgTypeDescription should be got from the 
            // table MS_Message_Types_Tbl instead of 
            // create anew
        }

        #endregion

    }
}