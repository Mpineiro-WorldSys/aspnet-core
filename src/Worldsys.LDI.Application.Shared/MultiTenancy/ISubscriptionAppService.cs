using System.Threading.Tasks;
using Abp.Application.Services;

namespace Worldsys.LDI.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
