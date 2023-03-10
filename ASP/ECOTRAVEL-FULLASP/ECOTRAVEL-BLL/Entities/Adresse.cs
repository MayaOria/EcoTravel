using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_BLL.Entities
{
    public class Adresse : IAdresse
    {
        public int IdAdresse { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string IsoPays { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        //IEnumerable<Logement> Logements { get; set; }
    }
}
