using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LuckyCatHomePage.Startup))]
namespace LuckyCatHomePage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
