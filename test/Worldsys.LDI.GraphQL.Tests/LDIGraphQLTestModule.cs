using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Worldsys.LDI.Configure;
using Worldsys.LDI.Startup;
using Worldsys.LDI.Test.Base;

namespace Worldsys.LDI.GraphQL.Tests
{
    [DependsOn(
        typeof(LDIGraphQLModule),
        typeof(LDITestBaseModule))]
    public class LDIGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LDIGraphQLTestModule).GetAssembly());
        }
    }
}