using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSiteMapProvider_AreaRouteName_446.Startup))]
namespace MvcSiteMapProvider_AreaRouteName_446
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
