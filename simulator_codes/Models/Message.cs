using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using MS_Simulator.DAL;

namespace MS_Simulator.Models
{
    /// <summary>
    /// Message.cs
    /// An abstract class, representing a general message, consisting of MessageHead
    /// and MessageBody
    /// </summary>
    public class Message
    {
        #region "Fields"
        private MessageHead msgHead;
        private MessageBody msgBody;

        #endregion

        #region "Functions"
        public static long GetNextMessageId(String msgTypeCode)
        {
            return MessageDAL.GetNextMessageId(msgTypeCode);
        }

        #endregion

        #region "Constructors"
        public Message()
        {
            this.msgBody = null;
            this.msgHead = null;

        }

        public Message(MessageHead msgHead, MessageBody msgBody)
        {
            this.msgHead = msgHead;
            this.msgBody = msgBody;

        }

        #endregion

    }

}