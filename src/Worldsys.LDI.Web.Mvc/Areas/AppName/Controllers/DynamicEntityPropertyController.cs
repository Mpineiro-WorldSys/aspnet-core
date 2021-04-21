using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.Authorization;
using Worldsys.LDI.DynamicEntityProperties;
using Worldsys.LDI.Web.Areas.AppName.Models.DynamicEntityProperty;
using Worldsys.LDI.Web.Controllers;

namespace Worldsys.LDI.Web.Areas.AppName.Controllers
{
    [Area("AppName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_DynamicEntityProperties)]
    public class DynamicEntityPropertyController : LDIControllerBase
    {
        private readonly IDynamicPropertyAppService _dynamicPropertyAppService;
        private readonly IDynamicEntityPropertyAppService _dynamicEntityPropertyAppService;

        public DynamicEntityPropertyController(
            IDynamicPropertyAppService dynamicPropertyAppService,
            IDynamicEntityPropertyAppService dynamicEntityPropertyAppService
        )
        {
            _dynamicPropertyAppService = dynamicPropertyAppService;
            _dynamicEntityPropertyAppService = dynamicEntityPropertyAppService;
        }

        [HttpGet]
        [Route("/AppName/DynamicEntityProperty/{entityFullName}")]
        public IActionResult Index(string entityFullName)
        {
            ViewBag.EntityFullName = entityFullName;
            return View();
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_DynamicEntityProperties_Create)]
        public async Task<IActionResult> CreateModal(string entityFullName)
        {
            var model = new CreateEntityDynamicPropertyViewModel()
            {
                EntityFullName = entityFullName
            };

            var allDynamicProperties = (await _dynamicPropertyAppService.GetAll()).Items.ToList();
            var definedPropertyIds = (await _dynamicEntityPropertyAppService.GetAllPropertiesOfAnEntity(new DynamicEntityPropertyGetAllInput() {EntityFullName = entityFullName}))
                .Items.Select(x => x.DynamicPropertyId).ToList();

            model.DynamicProperties = allDynamicProperties.Where(x => !definedPropertyIds.Contains(x.Id)).ToList();

            return PartialView("_CreateModal", model);
        }
    }
}