using System.ComponentModel.DataAnnotations;

namespace Worldsys.LDI.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}