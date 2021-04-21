using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Worldsys.LDI
{
    [DependsOn(typeof(LDICoreSharedModule))]
    public class LDIApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LDIApplicationSharedModule).GetAssembly());
        }
    }
}