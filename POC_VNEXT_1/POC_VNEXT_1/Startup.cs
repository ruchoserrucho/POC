using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POC_VNEXT_1.Startup))]
namespace POC_VNEXT_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
