using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Chat.Dto;

namespace Worldsys.LDI.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
