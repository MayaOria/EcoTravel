using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_ASP.Models.ClientViewModels
{
    public class ClientCreateForm
    {
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom de famille : ")]
        public string Nom { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Prénom : ")]
        public string Prenom { get; set; }
        [Required]
        [MaxLength(250)]
        [MinLength(5)]
        [EmailAddress]
        [DisplayName("Adresse e-mail : ")]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Pays (ISO2) : ")]
        public string IsoPays { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        [DisplayName("Telephone : ")]
        public string Telephone { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string Password { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [DisplayName("Confirmez le mot de passe : ")]
        public string ConfirmPass { get; set; }
    }
}
