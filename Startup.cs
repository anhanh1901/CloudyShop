using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudyShop.Startup))]
namespace CloudyShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
