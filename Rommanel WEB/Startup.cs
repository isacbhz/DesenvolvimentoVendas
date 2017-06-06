using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rommanel_WEB.Startup))]
namespace Rommanel_WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
