using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CasinoAdminMVC.Startup))]
namespace CasinoAdminMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
