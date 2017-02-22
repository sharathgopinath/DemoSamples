using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectManagementDemo.Web.Startup))]
namespace ProjectManagementDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
