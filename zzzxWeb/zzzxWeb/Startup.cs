using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zzzxWeb.Startup))]
namespace zzzxWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
