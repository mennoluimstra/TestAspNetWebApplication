using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAspNetWebApplication.Startup))]
namespace TestAspNetWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
