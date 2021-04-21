using System.Threading.Tasks;
using Abp.Application.Services;
using Worldsys.LDI.Sessions.Dto;

namespace Worldsys.LDI.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
