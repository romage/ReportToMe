using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportToMe.Web.Startup))]
namespace ReportToMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
