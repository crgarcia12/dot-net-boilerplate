using System.ComponentModel.DataAnnotations;

namespace Contoso.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}