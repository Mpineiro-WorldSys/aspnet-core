using System.Collections.Generic;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.MultiTenancy.Payments;

namespace Worldsys.LDI.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}