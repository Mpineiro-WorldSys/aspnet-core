using System.Threading.Tasks;
using Abp.Application.Services;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.MultiTenancy.Dto;

namespace Worldsys.LDI.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}