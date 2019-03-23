using System.ComponentModel.DataAnnotations;

namespace HealthBack.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}