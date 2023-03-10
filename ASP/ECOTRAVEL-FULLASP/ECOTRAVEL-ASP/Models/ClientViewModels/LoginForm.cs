using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECOTRAVEL_ASP.Models.ClientViewModels
{
    public class LoginForm
    {
        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        [EmailAddress]
        [DisplayName("Adresse email :")]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe:")]
        public string Password { get; set; }
    }
}
