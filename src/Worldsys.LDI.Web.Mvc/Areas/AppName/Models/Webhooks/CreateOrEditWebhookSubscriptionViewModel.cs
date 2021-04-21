using Abp.Application.Services.Dto;
using Abp.Webhooks;
using Worldsys.LDI.WebHooks.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
