using Worldsys.LDI.MultiTenancy.Payments;

namespace Worldsys.LDI.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}