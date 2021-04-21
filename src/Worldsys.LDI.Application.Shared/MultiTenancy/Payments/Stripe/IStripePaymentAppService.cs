using System.Threading.Tasks;
using Abp.Application.Services;
using Worldsys.LDI.MultiTenancy.Payments.Dto;
using Worldsys.LDI.MultiTenancy.Payments.Stripe.Dto;

namespace Worldsys.LDI.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}