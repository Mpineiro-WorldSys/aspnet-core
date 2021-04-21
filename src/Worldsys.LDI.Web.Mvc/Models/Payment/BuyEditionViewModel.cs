using System.Collections.Generic;
using Worldsys.LDI.Editions;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.MultiTenancy.Payments;
using Worldsys.LDI.MultiTenancy.Payments.Dto;

namespace Worldsys.LDI.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
