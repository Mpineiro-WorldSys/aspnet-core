using System.Threading.Tasks;
using Abp.Application.Services;
using Worldsys.LDI.Install.Dto;

namespace Worldsys.LDI.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}