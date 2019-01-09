using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HockeyDBWeb.Startup))]
namespace HockeyDBWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
