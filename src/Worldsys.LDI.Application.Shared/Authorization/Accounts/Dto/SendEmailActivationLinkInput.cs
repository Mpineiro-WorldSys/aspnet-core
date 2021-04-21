using System.ComponentModel.DataAnnotations;

namespace Worldsys.LDI.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}