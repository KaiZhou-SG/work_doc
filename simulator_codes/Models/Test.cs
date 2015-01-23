using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// Test.cs
    /// This class is a model working with the TestController.cs
    /// only for testing purpose, test if the environment works 
    /// </summary>
    public class Test
    {
        private string welcome;

        public string Welcome
        {
            get { return welcome; }
            set { welcome = value; }
        }

        public Test()
        {

        }

        public Test(string saySomething)
        {
            welcome = saySomething;
        }

        public string GetWelcome()
        {
            return welcome;
        }

        public string SetWelcomeString(string something)
        {
            welcome = something;

            return something;
        }
    }
}