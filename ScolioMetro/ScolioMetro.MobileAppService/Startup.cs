using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ScolioMetro.MobileAppService.Startup))]

namespace ScolioMetro.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}