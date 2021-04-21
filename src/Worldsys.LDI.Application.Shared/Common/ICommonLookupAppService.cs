using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Common.Dto;
using Worldsys.LDI.Editions.Dto;

namespace Worldsys.LDI.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}