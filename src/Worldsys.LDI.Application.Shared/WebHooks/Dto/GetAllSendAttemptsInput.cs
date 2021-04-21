using Worldsys.LDI.Dto;

namespace Worldsys.LDI.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
