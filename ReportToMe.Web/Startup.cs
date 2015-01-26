using Microsoft.Owin;
using Owin;
using ReportToMe.Web.App_Start;

[assembly: OwinStartupAttribute(typeof(ReportToMe.Web.Startup))]
namespace ReportToMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AutofacConfig.RegisterDespendencies(app);
            ConfigureAuth(app);
        }
    }
}
