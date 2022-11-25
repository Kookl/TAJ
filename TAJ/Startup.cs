using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TAJ.Startup))]
namespace TAJ
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
