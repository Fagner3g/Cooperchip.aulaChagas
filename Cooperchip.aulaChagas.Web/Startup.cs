using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cooperchip.aulaChagas.Web.Startup))]
namespace Cooperchip.aulaChagas.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
