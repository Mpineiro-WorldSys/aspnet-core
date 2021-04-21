using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.Authorization;
using Worldsys.LDI.Caching;
using Worldsys.LDI.Web.Areas.AppName.Models.Maintenance;
using Worldsys.LDI.Web.Controllers;

namespace Worldsys.LDI.Web.Areas.AppName.Controllers
{
    [Area("AppName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : LDIControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items
            };

            return View(model);
        }
    }
}