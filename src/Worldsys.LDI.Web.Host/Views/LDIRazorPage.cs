using Abp.AspNetCore.Mvc.Views;

namespace Worldsys.LDI.Web.Views
{
    public abstract class LDIRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected LDIRazorPage()
        {
            LocalizationSourceName = LDIConsts.LocalizationSourceName;
        }
    }
}
