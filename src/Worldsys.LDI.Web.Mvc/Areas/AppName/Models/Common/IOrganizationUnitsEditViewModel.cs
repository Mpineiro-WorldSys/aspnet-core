using System.Collections.Generic;
using Worldsys.LDI.Organizations.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}