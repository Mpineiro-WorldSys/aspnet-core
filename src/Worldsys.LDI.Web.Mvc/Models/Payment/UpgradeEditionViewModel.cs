using System.Collections.Generic;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.MultiTenancy.Payments;

namespace Worldsys.LDI.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}