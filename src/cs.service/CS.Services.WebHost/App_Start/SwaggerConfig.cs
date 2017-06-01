using System.Configuration;
using System.Web.Http;
using Swashbuckle.Application;


namespace CS.Service.WebHost
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableSwagger(docsConfig =>
            {
                docsConfig.RootUrl(req => ConfigurationManager.AppSettings["SwaggerUrl"].TrimEnd('/'));
                docsConfig.SingleApiVersion("v1", "CS.Service.WebHost");

            }).EnableSwaggerUi(c => c.DisableValidator());
        }
    }
}
