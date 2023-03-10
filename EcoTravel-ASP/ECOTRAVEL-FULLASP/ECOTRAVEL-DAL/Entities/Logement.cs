using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Entities
{
    public class Logement : ILogement
    {
        //INT
        public int IdLogement { get; set; }
        //NVARCHAR(50)
        public string Nom { get; set; }
        //NVARCHAR(255)
        public string DescriptionCourte { get; set; }
        //NVARCHAR(MAX)
        public string DescriptionLongue { get; set; }
        //MONEY
        public decimal PrixJournalier { get; set; }
        //TINYINT
        public int NbChambres { get; set; }
        //TINYINT
        public int NbPieces { get; set; }
        //TINYINT
        public int Capacite { get; set; }
        //TINYINT
        public int NbSDB { get; set; }
        //TINYINT
        public int NbWC { get; set; }
        //BIT
        public bool Balcon { get; set; }
        //BIT
        public bool Wifi { get; set; }
        //BIT
        public bool Airco { get; set; }
        //BIT
        public bool Minibar { get; set; }
        //BIT
        public bool Animaux { get; set; }
        //BIT
        public bool Piscine { get; set; }
        //BIT
        public bool Voiturier { get; set; }
        //BIT
        public bool RoomService { get; set; }
        //DATE
        public DateTime DateAjout { get; set; }
        //INT
        public int IdAdresse { get; set; }
        //INT
        public int IdClient { get; set; }
        //INT
        public int IdTypeLogement { get; set; }
    }
}
