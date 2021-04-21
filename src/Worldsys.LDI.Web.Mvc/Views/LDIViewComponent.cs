using Abp.AspNetCore.Mvc.ViewComponents;

namespace Worldsys.LDI.Web.Views
{
    public abstract class LDIViewComponent : AbpViewComponent
    {
        protected LDIViewComponent()
        {
            LocalizationSourceName = LDIConsts.LocalizationSourceName;
        }
    }
}