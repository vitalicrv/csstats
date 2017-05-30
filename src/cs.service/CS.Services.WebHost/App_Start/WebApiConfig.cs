using System.Configuration;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Application;

namespace CS.Service.WebHost
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
            config.Routes.MapHttpRoute("Swagger", "", null, null, new RedirectHandler(OurRouteResolver, "swagger/ui/index"));
        }

        private static string OurRouteResolver(HttpRequestMessage arg)
        {
            return ConfigurationManager.AppSettings["SwaggerUrl"]?.TrimEnd('/') ?? "http://localhost:1959";
        }
    }
}
