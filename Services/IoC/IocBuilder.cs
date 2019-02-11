using System;
using System.ComponentModel;
using DataLayer.Models;
using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using System.Reflection;

namespace Services.IoC
{
    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<Repository>().As<IRepository>().InstancePerRequest();
            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}