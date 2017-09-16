using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMovie2.Startup))]
namespace MVCMovie2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
