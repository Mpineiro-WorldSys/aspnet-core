using System.Threading.Tasks;
using Worldsys.LDI.Authorization.Users;

namespace Worldsys.LDI.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
