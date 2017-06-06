using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(X_Web_Rommanel.Startup))]
namespace X_Web_Rommanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
