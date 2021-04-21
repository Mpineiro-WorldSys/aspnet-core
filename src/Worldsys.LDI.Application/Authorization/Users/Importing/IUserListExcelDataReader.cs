using System.Collections.Generic;
using Worldsys.LDI.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace Worldsys.LDI.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
