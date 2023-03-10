using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Entities
{
    public class TypeLogement : ITypeLogement
    {
        //INT
        public int IdTypeLogement { get; set; }
        //NVARCHAR(50)
        public string Nom { get; set; }
    }
}
