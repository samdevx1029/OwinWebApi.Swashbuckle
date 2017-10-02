using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using OwinWebApi.Swashbuckle;
using Swashbuckle.Application;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

[assembly: OwinStartup(typeof(Startup))]

namespace OwinWebApi.Swashbuckle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            // Configure routing
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", "{controller}/{id}",
                defaults: new { controller = "Value", id = RouteParameter.Optional }
                );

            // Configure Swashbuckle (after installing Swashbuckle.Core)
            config
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Crimson API");
                    c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\OwinWebApiSwashbuckle.xml");
                    c.PrettyPrint();
                })
                .EnableSwaggerUi();

            // Start using the main Owin middleware (after all pipeline has been set up as desired above)
            appBuilder.UseWebApi(config);
        }
    }
}