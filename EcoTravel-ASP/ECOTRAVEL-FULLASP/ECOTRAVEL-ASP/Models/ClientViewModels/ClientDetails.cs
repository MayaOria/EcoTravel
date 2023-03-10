using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_ASP.Models.ClientViewModels
{
    public class ClientDetails
    {
        [DisplayName("Nom de famille : ")]
        public string Nom { get; set; }

        [DisplayName("Prénom : ")]
        public string Prenom { get; set; }

        [EmailAddress]
        [DisplayName("Adresse e-mail : ")]
        public string Email { get; set; }

        [DisplayName("Code Pays : ")]
        public string IsoPays { get; set; }

        [DisplayName("Téléphone : ")]
        public string Telephone { get; set; }

    }
}
