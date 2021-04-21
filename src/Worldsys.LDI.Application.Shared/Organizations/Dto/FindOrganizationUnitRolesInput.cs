using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Organizations.Dto
{
    public class FindOrganizationUnitRolesInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}