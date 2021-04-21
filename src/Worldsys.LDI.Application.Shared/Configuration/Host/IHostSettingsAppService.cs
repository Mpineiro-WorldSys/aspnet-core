using System.Threading.Tasks;
using Abp.Application.Services;
using Worldsys.LDI.Configuration.Host.Dto;

namespace Worldsys.LDI.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
