using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperMarketMgmtSystem.Startup))]
namespace SuperMarketMgmtSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
