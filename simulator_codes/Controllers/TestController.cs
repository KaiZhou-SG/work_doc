using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//
using MS_Simulator.Models;

namespace MS_Simulator.Controllers
{
    /// <summary>
    /// TestController.cs
    /// This class works with Test.cs only for testing purpose.
    /// To test if the environment works.
    /// </summary>
    public class TestController : ApiController
    {
        [HttpGet]
        [ActionName("SayHello")]
        public string SayHello()
        {
            Test test = new Test("Hello world! From ASP.NET.");
            return test.GetWelcome();
        }
    }
}
