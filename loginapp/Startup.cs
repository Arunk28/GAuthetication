using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loginapp.Startup))]
namespace loginapp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
