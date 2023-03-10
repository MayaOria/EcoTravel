using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_BLL.Entities
{
    public class TypeLogement : ITypeLogement
    {
        public int IdTypeLogement { get; set; }
        public string Nom { get; set; }
        IEnumerable<Logement> Logements { get; set; }
    }
}
