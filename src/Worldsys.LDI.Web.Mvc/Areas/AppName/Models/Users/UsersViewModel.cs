using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Authorization.Permissions.Dto;
using Worldsys.LDI.Web.Areas.AppName.Models.Common;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Users
{
    public class UsersViewModel : IPermissionsEditViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}