using System.Collections.Generic;
using Worldsys.LDI.Authorization.Users.Importing.Dto;
using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
