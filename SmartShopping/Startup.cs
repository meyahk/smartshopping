using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartShopping.Startup))]
namespace SmartShopping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
