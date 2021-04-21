using System.Collections.Generic;
using Worldsys.LDI.DashboardCustomization.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
