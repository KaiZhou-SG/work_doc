using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
// 
using FM.FMSystem.DAL;

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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // 2015-01-19 Zhou Kai adds route for processing Msg1
            config.Routes.MapHttpRoute(
                name: "SE1stLeg_Register",
                routeTemplate: "api/{controller}/{action}"

                );

            config.Routes.MapHttpRoute(
                name: "EnvironmentTesting",
                routeTemplate: "api/{controller}/{action}"
                );

            // config the database connection string
            FMGlobalSettings.TheInstance.GetSQLUserPassword();
            FMGlobalSettings.TheInstance.SetConnectionString(new string[] {
                "zhoukai\\sql2012", "FM80_SG_USS_UAT",
                FMGlobalSettings.TheInstance.sqlUser, FMGlobalSettings.TheInstance.sqlPassword});
        }
    }
}
