using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dbtest2.Startup))]
namespace dbtest2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
