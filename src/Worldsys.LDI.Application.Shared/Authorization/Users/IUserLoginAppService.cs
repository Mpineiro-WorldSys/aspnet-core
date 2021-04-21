using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Authorization.Users.Dto;

namespace Worldsys.LDI.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
