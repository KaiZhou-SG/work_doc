using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MS_Simulator
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"//,
                // defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "Register_SE_1stLeg",
                routeTemplate: "api/{controller}/reg/{action}"
            );

            #region "For testing only"
            config.Routes.MapHttpRoute(
                name: "Test_TheMessageController",
                routeTemplate: "api/{controller}/{action}/{id}"
            );

            #endregion
        }
    }
}
