using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIQmvc.Startup))]
namespace CIQmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
