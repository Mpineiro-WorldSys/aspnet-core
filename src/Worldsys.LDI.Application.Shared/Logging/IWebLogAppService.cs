using Abp.Application.Services;
using Worldsys.LDI.Dto;
using Worldsys.LDI.Logging.Dto;

namespace Worldsys.LDI.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
