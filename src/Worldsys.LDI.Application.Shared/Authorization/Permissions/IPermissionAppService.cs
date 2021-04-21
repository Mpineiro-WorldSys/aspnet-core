using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Authorization.Permissions.Dto;

namespace Worldsys.LDI.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
