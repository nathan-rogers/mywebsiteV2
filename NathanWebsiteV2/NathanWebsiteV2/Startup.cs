using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NathanWebsiteV2.Startup))]
namespace NathanWebsiteV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
