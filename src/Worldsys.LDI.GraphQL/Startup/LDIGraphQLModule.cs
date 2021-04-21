using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Worldsys.LDI.Startup
{
    [DependsOn(typeof(LDICoreModule))]
    public class LDIGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LDIGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}