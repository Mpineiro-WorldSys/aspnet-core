using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.DashboardCustomization;
using Worldsys.LDI.DashboardCustomization.Dto;
using Worldsys.LDI.Web.Areas.AppName.Models.CustomizableDashboard;
using Worldsys.LDI.Web.Controllers;
using System.Linq;
using System.Threading.Tasks;
using Worldsys.LDI.Web.Areas.AppName.Startup;

namespace Worldsys.LDI.Web.Areas.AppName.Controllers
{
    public abstract class CustomizableDashboardControllerBase : LDIControllerBase
    {
        protected readonly IDashboardCustomizationAppService DashboardCustomizationAppService;
        protected readonly DashboardViewConfiguration DashboardViewConfiguration;

        protected CustomizableDashboardControllerBase(
            DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService)
        {
            DashboardViewConfiguration = dashboardViewConfiguration;
            DashboardCustomizationAppService = dashboardCustomizationAppService;
        }

        public async Task<PartialViewResult> AddWidgetModal(string dashboardName, string pageId)
        {
            var userDashboard = await DashboardCustomizationAppService.GetUserDashboard(
                new GetDashboardInput
                {
                    DashboardName = dashboardName,
                    Application = LDIDashboardCustomizationConsts.Applications.Mvc
                }
            );

            var page = userDashboard.Pages.Single(p => p.Id == pageId);

            var filteredWidgetsByPermission = DashboardCustomizationAppService.GetAllWidgetDefinitions(new GetDashboardInput() { DashboardName = dashboardName })
                .Where(widgetDef => page.Widgets.All(widgetOnPage => widgetOnPage.WidgetId != widgetDef.Id))
                .ToList();

            var viewModel = new AddWidgetViewModel
            {
                Widgets = filteredWidgetsByPermission,
                DashboardName = dashboardName,
                PageId = pageId
            };

            return PartialView("~/Areas/AppName/Views/Shared/Components/CustomizableDashboard/_AddWidgetModal.cshtml", viewModel);
        }

        protected async Task<ActionResult> GetView(string dashboardName)
        {
            var dashboardDefinition = DashboardCustomizationAppService.GetDashboardDefinition(
                new GetDashboardInput
                {
                    DashboardName = dashboardName,
                    Application = LDIDashboardCustomizationConsts.Applications.Mvc
                }
            );

            var userDashboard = await DashboardCustomizationAppService.GetUserDashboard(new GetDashboardInput
                {
                    DashboardName = dashboardName,
                    Application = LDIDashboardCustomizationConsts.Applications.Mvc
                }
            );

            // Show only view defined widgets
            foreach (var userDashboardPage in userDashboard.Pages)
            {
                userDashboardPage.Widgets = userDashboardPage.Widgets
                    .Where(w => DashboardViewConfiguration.WidgetViewDefinitions.ContainsKey(w.WidgetId)).ToList();
            }

            dashboardDefinition.Widgets = dashboardDefinition.Widgets.Where(dw => userDashboard.Pages.Any(p => p.Widgets.Select(w => w.WidgetId).Contains(dw.Id))).ToList();

            return View("~/Areas/AppName/Views/Shared/Components/CustomizableDashboard/Index.cshtml",
                new CustomizableDashboardViewModel(
                    dashboardDefinition,
                    userDashboard)
                );
        }
    }
}