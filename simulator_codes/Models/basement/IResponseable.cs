using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Net.Http;

namespace MS_Simulator.Models.Basement
{
    interface IResponseable
    {
        HttpResponseMessage GetResponseMessage(int msgId, string msgCode);
    }
}
