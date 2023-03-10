using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_BLL.Entities
{
    public class Logement : ILogement
    {
        public int IdLogement { get; set; }
        
        public string Nom { get; set; }
        
        public string DescriptionCourte { get; set; }
        
        public string DescriptionLongue { get; set; }
        
        public decimal PrixJournalier { get; set; }
        
        public int NbChambres { get; set; }
        
        public int NbPieces { get; set; }
        
        public int Capacite { get; set; }
        
        public int NbSDB { get; set; }
        
        public int NbWC { get; set; }
        
        public bool Balcon { get; set; }
        
        public bool Wifi { get; set; }
        
        public bool Airco { get; set; }
        
        public bool Minibar { get; set; }
        
        public bool Animaux { get; set; }
        
        public bool Piscine { get; set; }
        
        public bool Voiturier { get; set; }
        
        public bool RoomService { get; set; }
        
        public DateTime DateAjout { get; set; }
        
        public int IdAdresse { get; set; }
        
        public int IdClient { get; set; }
        
        public int IdTypeLogement { get; set; }
    }
}
