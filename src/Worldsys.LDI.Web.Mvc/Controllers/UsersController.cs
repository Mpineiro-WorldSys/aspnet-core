using Abp.AspNetCore.Mvc.Authorization;
using Worldsys.LDI.Authorization;
using Worldsys.LDI.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace Worldsys.LDI.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}