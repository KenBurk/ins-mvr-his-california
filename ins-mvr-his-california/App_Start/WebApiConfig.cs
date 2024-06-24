using Microsoft.HostIntegration.ConfigurationSectionHandlers.Ti.Wip;
using System.Configuration;
using System.Web.Http;

namespace ins_mvr_his_california
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

            var ivpConfig = ConfigurationManager.GetSection("hostIntegration.ti.wip.ivp") as IvpConfigurationSectionHandler;
            ConfigProgrammingModels programmingModel = ivpConfig.ExecutionParameters.ConfigProgrammingModel;

        }
    }
}
