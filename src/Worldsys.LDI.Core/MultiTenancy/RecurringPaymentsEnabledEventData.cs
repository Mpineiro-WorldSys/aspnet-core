using Abp.Events.Bus;

namespace Worldsys.LDI.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}