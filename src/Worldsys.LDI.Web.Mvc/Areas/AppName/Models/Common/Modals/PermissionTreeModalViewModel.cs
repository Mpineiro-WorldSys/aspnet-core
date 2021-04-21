using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worldsys.LDI.Authorization.Permissions.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
