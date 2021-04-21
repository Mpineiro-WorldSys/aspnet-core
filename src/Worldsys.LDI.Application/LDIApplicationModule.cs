using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Worldsys.LDI.Authorization;

namespace Worldsys.LDI
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(LDIApplicationSharedModule),
        typeof(LDICoreModule)
        )]
    public class LDIApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LDIApplicationModule).GetAssembly());
        }
    }
}