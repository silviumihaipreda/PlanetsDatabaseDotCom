using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Owin;

[assembly: OwinStartup(typeof(PlanetsDatabaseDotCom.Startup))]

namespace PlanetsDatabaseDotCom
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseNancy();

            app.UseStageMarker(PipelineStage.MapHandler);
        }
    }
}
