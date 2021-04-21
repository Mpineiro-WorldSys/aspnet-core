using System.Threading.Tasks;
using Abp.Webhooks;

namespace Worldsys.LDI.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
