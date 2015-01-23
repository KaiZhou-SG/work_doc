using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using FM.FMSystem.BLL;
using MS_Simulator.DAL;
//
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MS_Simulator.Models
{
    /// <summary>
    /// TheMessage.cs
    /// The registering message for the Sea-Export 1st Leg, including head and body
    /// </summary>
    [Serializable()]
    public class TheMessage : Message
    {
        #region "Fields"
        private MsgSE1stLegHead msgHead;
        private MsgSE1stLegBody msgBody;

        public MsgSE1stLegHead MsgHead
        {
            get { return msgHead; }
            set { msgHead = value; }
        }

        public MsgSE1stLegBody MsgBody
        {
            get { return msgBody; }
            set { msgBody = value; }
        }

        #endregion

        #region "Functions"
        public TheMessage RegisterSE1stLeg(TheMessage msg)
        {
            // insert the registering message into database, and this message will be sent
            // to driver MDT
            TheMessage rtnMsg = new TheMessage();
            try
            {
                rtnMsg = MsgSE1stLegRegMessageDAL.RegisterSE1stLeg(msg);

                return rtnMsg;
            }
            catch (FMException fme) { throw fme; }
        }

        #endregion

        #region "Constructors"
        public TheMessage()
        {
            this.msgHead = null;
            this.msgBody = null;

        }

        public TheMessage(MsgSE1stLegHead msgHeader,
            MsgSE1stLegBody msgBody)
        {
            this.msgHead = msgHeader;
            this.msgBody = msgBody;
        }

        #endregion

    }
}