using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Caching.Dto;

namespace Worldsys.LDI.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
