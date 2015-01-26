using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
//
using FM.FMSystem.DAL;
using MS_Simulator.Models.Basement;

namespace MS_Simulator
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // config the database connection string
            FMGlobalSettings.TheInstance.SetConnectionStringForMS(
                new string[] {
                "zhoukai\\sql2012", "FM80_SG_USS_UAT",
                "ipl", "support" }
                );

            // initialize the message code to message type code mapping
            MessageType.IniMessageCodeToTypeCodeMapping();

            GlobalConfiguration.Configure(WebApiConfig.Register);


        }
    }
}
