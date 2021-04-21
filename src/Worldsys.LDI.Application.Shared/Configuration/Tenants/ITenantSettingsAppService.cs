using System.Threading.Tasks;
using Abp.Application.Services;
using Worldsys.LDI.Configuration.Tenants.Dto;

namespace Worldsys.LDI.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
