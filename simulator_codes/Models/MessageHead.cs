using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    [Serializable()]
    public class MessageHead
    {
        #region "Fields"
        private long msgId;
        private MessageType msgType;
        public MessageType MsgType
        {
            get { return msgType; }
            set { msgType = value; }
        }
        public long MsgId
        {
            get { return msgId; }
            set { msgId = value; }
        }

        #endregion

        #region "Functions"
        public virtual bool GeneralSelfCheck()
        {
            // it's a general self checking, every specific
            // MessageHead can just use it or implement its own
            // self-checking rules by overwriting this method

            // rule 1: 
            // the message code should be a two digit integer
            // e.g. 07, 81, 25...
            bool isNumber = false;
            int nTmp = 0;
            isNumber = int.TryParse(this.msgType.Msg_Code, out nTmp);
            if (isNumber && nTmp >= 0 && nTmp < 100)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region "Constructors"
        public MessageHead()
        {
            this.msgId = 0;
            // default message type
            this.msgType = new MessageType();
        }

        public MessageHead(long msgId, string msgCode, string msgTypeCode,
            string msgTypeDescription)
        {
            this.msgId = msgId;
            this.msgType = new MessageType(msgCode,
                msgTypeCode, msgTypeDescription);
        }

        public MessageHead(long msgId, MessageType msgType)
        {
            this.msgId = msgId;
            this.msgType = msgType;
        }

        #endregion
    }
}