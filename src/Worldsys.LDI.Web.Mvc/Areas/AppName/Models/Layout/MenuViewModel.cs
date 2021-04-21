using Abp.Application.Navigation;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}