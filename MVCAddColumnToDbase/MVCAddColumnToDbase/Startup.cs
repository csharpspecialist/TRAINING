using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAddColumnToDbase.Startup))]
namespace MVCAddColumnToDbase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
