using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThinkZone.Startup))]
namespace ThinkZone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
