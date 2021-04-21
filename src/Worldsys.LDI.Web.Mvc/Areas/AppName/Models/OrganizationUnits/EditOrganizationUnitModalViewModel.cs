using Abp.AutoMapper;
using Abp.Organizations;

namespace Worldsys.LDI.Web.Areas.AppName.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}