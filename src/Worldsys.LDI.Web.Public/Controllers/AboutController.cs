using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.Web.Controllers;

namespace Worldsys.LDI.Web.Public.Controllers
{
    public class AboutController : LDIControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}