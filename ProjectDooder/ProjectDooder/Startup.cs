using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectDooder.Startup))]
namespace ProjectDooder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
