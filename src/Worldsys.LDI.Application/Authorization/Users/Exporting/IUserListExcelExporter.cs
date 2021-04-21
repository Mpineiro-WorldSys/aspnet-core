using System.Collections.Generic;
using Worldsys.LDI.Authorization.Users.Dto;
using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}