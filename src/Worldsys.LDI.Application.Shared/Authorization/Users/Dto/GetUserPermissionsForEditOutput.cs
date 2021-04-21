using System.Collections.Generic;
using Worldsys.LDI.Authorization.Permissions.Dto;

namespace Worldsys.LDI.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}