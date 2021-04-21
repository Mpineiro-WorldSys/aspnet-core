using System.Collections.Generic;
using Worldsys.LDI.Auditing.Dto;
using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
