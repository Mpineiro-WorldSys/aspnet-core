using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.Web.Areas.AppName.Models.Layout;
using Worldsys.LDI.Web.Views;

namespace Worldsys.LDI.Web.Areas.AppName.Views.Shared.Components.AppNameLanguageSwitch
{
    public class AppNameLanguageSwitchViewComponent : LDIViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AppNameLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
