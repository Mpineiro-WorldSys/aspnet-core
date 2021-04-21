using Worldsys.LDI.Editions;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.MultiTenancy.Payments;
using Worldsys.LDI.Security;
using Worldsys.LDI.MultiTenancy.Payments.Dto;

namespace Worldsys.LDI.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
