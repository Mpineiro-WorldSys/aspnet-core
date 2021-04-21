using System.Collections.Generic;
using Worldsys.LDI.Authorization.Permissions.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}