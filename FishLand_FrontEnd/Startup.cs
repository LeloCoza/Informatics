using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FishLand_FrontEnd.Startup))]
namespace FishLand_FrontEnd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
