using System.ComponentModel.DataAnnotations;

namespace Worldsys.LDI.Phonebook.Dto
{
    public class AddPhoneInput
    {
        [Range(1, int.MaxValue)]
        public int PersonId { get; set; }

        [Required]
        public PhoneType Tipo { get; set; }

        [Required]
        [MaxLength(PhoneConsts.MaxNumberLength)]
        public string Number { get; set; }
    }

}
