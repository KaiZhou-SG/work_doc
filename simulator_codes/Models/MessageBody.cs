using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    [Serializable()]
    public class MessageBody
    {
        public virtual bool GeneralSelfCheck()
        {
            // did nothing here so far,
            // wait for particular message body to implement it

            return false;
        }
    }
}