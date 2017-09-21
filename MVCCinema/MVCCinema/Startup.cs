using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCinema.Startup))]
namespace MVCCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
