using System.ComponentModel.DataAnnotations;

namespace Worldsys.LDI.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
