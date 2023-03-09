using ECOTRAVEL_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Mappers
{
    static class Mappers
    {
        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                IdClient = (int)record[nameof(Client.IdClient)],
                Nom = (string)record[nameof(Client.Nom)],
                Prenom = (string)record[nameof(Client.Prenom)],
                Email = (string)record[nameof(Client.Email)],
                IsoPays = (string)record[nameof(Client.IsoPays)],
                Telephone = (string)record[nameof(Client.Telephone)],
                Password = "********"
            };
        }
    }
}
