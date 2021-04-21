using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Worldsys.LDI.Web.Public.Views
{
    public abstract class LDIRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LDIRazorPage()
        {
            LocalizationSourceName = LDIConsts.LocalizationSourceName;
        }
    }
}
