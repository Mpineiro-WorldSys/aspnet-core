using System.Collections.Generic;
using Abp;
using Worldsys.LDI.Chat.Dto;
using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
