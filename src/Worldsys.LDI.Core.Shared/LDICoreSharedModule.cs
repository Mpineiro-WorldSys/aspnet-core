using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Worldsys.LDI
{
    public class LDICoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LDICoreSharedModule).GetAssembly());
        }
    }
}