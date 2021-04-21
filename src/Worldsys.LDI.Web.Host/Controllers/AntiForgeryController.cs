using Microsoft.AspNetCore.Antiforgery;

namespace Worldsys.LDI.Web.Controllers
{
    public class AntiForgeryController : LDIControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
