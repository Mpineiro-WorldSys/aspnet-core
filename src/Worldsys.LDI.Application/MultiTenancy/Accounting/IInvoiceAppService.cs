using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Worldsys.LDI.MultiTenancy.Accounting.Dto;

namespace Worldsys.LDI.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
