using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    public enum MessageCodesEnum : int
    {
        COL = 10, // 1st leg of a Sea-Export job
        EXP = 11, // 2nd leg of a Sea-Export job
        IMP = 12, // 1st leg of a Sea-Import job
        RTN = 13, // 2nd leg of a Sea-Import job
        FWD = 14, // growth venture forward job info to driver mdt
        REQ = 15, // driver request a job via keying in MDT
        ACK = 16 // acknowledgements from all parties
    }
}