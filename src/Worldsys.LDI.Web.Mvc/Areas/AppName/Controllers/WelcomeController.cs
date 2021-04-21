using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.Web.Controllers;

namespace Worldsys.LDI.Web.Areas.AppName.Controllers
{
    [Area("AppName")]
    [AbpMvcAuthorize]
    public class WelcomeController : LDIControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}