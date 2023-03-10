using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_BLL.Entities
{
    public class Client : IClient
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string IsoPays { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
    }
}
