using ECOTRAVEL_BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOTRAVEL_ASP.Models.LogementViewModels
{
    public class LogementCreateForm
    {
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom du logement : ")]
        public string Nom { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        [DisplayName("Description courte: ")]
        public string DescriptionCourte { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(1)]
        [DisplayName("Description longue : ")]
        public string DescriptionLongue { get; set; }
        [Required]
        [DisplayName("Prix par jour : ")]
        
        public decimal PrixJournalier { get; set; }
        [Required]
        [DisplayName("Nombre de chambre : ")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Le champ doit être un nombre entier valide.")]
        public int NbChambres { get; set; }
        [Required]
        [DisplayName("Nombre de pièces de vie : ")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Le champ doit être un nombre entier valide.")]
        public int NbPieces { get; set; }
        [Required]
        [DisplayName("Capacité maximale : ")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Le champ doit être un nombre entier valide.")]
        public int Capacite { get; set; }
        [Required]
        [DisplayName("Nombre de salles de bain : ")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Le champ doit être un nombre entier valide.")]
        public int NbSDB { get; set; }
        [Required]
        [DisplayName("Nombre de toilettes : ")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Le champ doit être un nombre entier valide.")]
        public int NbWC { get; set; }
        [Required]
        [DisplayName("Y a-t-il  un balcon ? : ")]
        
        public bool Balcon { get; set; }
        [Required]
        [DisplayName("Y a-t-il  du WIFI ? : ")]

        public bool Wifi { get; set; }
        [Required]
        [DisplayName("Y a-t-il  de l'Airco ? : ")]
        public bool Airco { get; set; }
        [Required]
        [DisplayName("Y a-t-il  un minibar ? : ")]
        public bool Minibar { get; set; }
        [Required]
        [DisplayName("Les animaux sont-ils admis ? : ")]
        public bool Animaux { get; set; }
        [Required]
        [DisplayName("Y a-t-il  une piscine ? : ")]
        public bool Piscine { get; set; }
        [Required]
        [DisplayName("Y a-t-il  un service voiturier ? : ")]
        public bool Voiturier { get; set; }
        [Required]
        [DisplayName("Y a-t-il  un roomservice ? : ")]
        public bool RoomService { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAjout { get; set; }


        [ScaffoldColumn(false)]
        public int IdTypeLogement { get; set; } = 0;
        [ScaffoldColumn(false)]
        public int IdAdresse { get; set; } = 0;
        [ScaffoldColumn(false)]
        public int IdClient { get; set; } = 0;

        [ScaffoldColumn(false)]
        public List<TypeLogement> typeLogement { get; set; }



        //Adresse à gérer !

    }
}
