using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;
using Worldsys.LDI.Authorization.Users.Profile;
using Worldsys.LDI.Storage;

namespace Worldsys.LDI.Web.Controllers
{
    [Authorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService) :
            base(tempFileCacheManager, profileAppService)
        {
        }
    }
}