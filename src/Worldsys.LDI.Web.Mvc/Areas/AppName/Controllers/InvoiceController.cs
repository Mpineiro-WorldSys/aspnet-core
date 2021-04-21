using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.MultiTenancy.Accounting;
using Worldsys.LDI.Web.Areas.AppName.Models.Accounting;
using Worldsys.LDI.Web.Controllers;

namespace Worldsys.LDI.Web.Areas.AppName.Controllers
{
    [Area("AppName")]
    public class InvoiceController : LDIControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}