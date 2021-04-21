using Abp.AutoMapper;
using Worldsys.LDI.Authorization.Roles.Dto;
using Worldsys.LDI.Web.Areas.AppName.Models.Common;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}