using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Entities
{
    public class Client : IClient
    {
        //INT
        public int IdClient { get; set; }
        //NVARCHAR(50)
        public string Nom { get; set; }
        //NVARCHAR(50)
        public string Prenom { get; set; }
        //NVARCHAR(255)
        public string Email { get; set; }
        //CHAR(2)
        public string IsoPays { get; set; }
        //NVARCHAR(50)
        public string Telephone { get; set; }
        //NVARCHAR(32)
        public string Password { get; set; }
    }
}
