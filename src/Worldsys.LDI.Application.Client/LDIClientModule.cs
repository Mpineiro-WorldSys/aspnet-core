using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Worldsys.LDI
{
    public class LDIClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LDIClientModule).GetAssembly());
        }
    }
}
