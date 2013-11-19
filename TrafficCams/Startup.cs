using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrafficCams.Startup))]
namespace TrafficCams
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
