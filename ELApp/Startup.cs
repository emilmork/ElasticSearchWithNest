using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELApp.Startup))]
namespace ELApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
