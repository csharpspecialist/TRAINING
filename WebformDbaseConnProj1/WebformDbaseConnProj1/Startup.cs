using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebformDbaseConnProj1.Startup))]
namespace WebformDbaseConnProj1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
