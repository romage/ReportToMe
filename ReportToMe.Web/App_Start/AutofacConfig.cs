using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReportToMe.Data;
using ReportToMe.Services;
using ReportToMe.Web.Interfaces;
using ReportToMe.Services.Interfaces;

namespace ReportToMe.Web.App_Start
{
    public class AutofacConfig
    {
        //http://stackoverflow.com/questions/15226536/register-generic-type-with-autofac//


        public static void RegisterDespendencies(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            var mvcAssembly = typeof(MvcApplication).Assembly;
            var svcAssembly = typeof(HomeService).Assembly;
            var repoAssembly = typeof(RepositoryBase).Assembly;

            builder
                .RegisterType(typeof(ReportToMeDataContext))
                .AsSelf()
                .InstancePerLifetimeScope();

            builder
                .RegisterGeneric(typeof(ReportToMe.Data.Repository<>))
                .As(typeof(IRepository<>));

            builder
                .RegisterType(typeof(UnitOfWork))
                .As(typeof(IUnitOfWork));

            builder.RegisterAssemblyTypes(svcAssembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            builder
                .RegisterType<MeetingRepository>()
                .As<IMeetingRepository>();

            builder.RegisterControllers(mvcAssembly);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
        }
    }
}