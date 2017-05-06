using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ooad.Startup))]
namespace ooad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
