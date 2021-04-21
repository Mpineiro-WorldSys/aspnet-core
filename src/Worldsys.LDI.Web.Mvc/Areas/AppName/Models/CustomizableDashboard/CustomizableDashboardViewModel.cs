using Worldsys.LDI.DashboardCustomization;
using Worldsys.LDI.DashboardCustomization.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.CustomizableDashboard
{
    public class CustomizableDashboardViewModel
    {
        public DashboardOutput DashboardOutput { get; }

        public Dashboard UserDashboard { get; }

        public CustomizableDashboardViewModel(
            DashboardOutput dashboardOutput,
            Dashboard userDashboard)
        {
            DashboardOutput = dashboardOutput;
            UserDashboard = userDashboard;
        }
    }
}