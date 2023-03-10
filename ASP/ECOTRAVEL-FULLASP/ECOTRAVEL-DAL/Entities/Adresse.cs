using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Entities
{
    public class Adresse : IAdresse
    {
        //INT
        public int IdAdresse { get; set; }
        //NVARCHAR(255)
        public string Rue { get; set; }
        //NVARCHAR(50)
        public string Numero { get; set; }
        //NVARCHAR(50)
        public string CodePostal { get; set; }
        //CHAR(2)
        public string IsoPays { get; set; }
        //DECIMAL(10, 8)
        public double Latitude { get; set; }
        //DECIMAL(11, 8)
        public double Longitude { get; set; }
    }
}
