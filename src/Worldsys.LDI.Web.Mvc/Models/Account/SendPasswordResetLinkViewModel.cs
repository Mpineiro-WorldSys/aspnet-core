using System.ComponentModel.DataAnnotations;

namespace Worldsys.LDI.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}