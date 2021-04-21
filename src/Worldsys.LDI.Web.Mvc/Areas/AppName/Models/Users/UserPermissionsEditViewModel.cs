using Abp.AutoMapper;
using Worldsys.LDI.Authorization.Users;
using Worldsys.LDI.Authorization.Users.Dto;
using Worldsys.LDI.Web.Areas.AppName.Models.Common;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}