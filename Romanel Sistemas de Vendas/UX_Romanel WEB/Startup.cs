using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UX_Romanel_WEB.Startup))]
namespace UX_Romanel_WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
