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

        public static Proprietaire ToProprietaire(this IDataRecord record)
        {
            if (record is null) return null;
            return new Proprietaire()
            {
                IdClient = (int)record[nameof(Proprietaire.IdClient)],
                Nom = (string)record[nameof(Proprietaire.Nom)],
                Prenom = (string)record[nameof(Proprietaire.Prenom)],
                Email = (string)record[nameof(Proprietaire.Email)],
                IsoPays = (string)record[nameof(Proprietaire.IsoPays)],
                Telephone = (string)record[nameof(Proprietaire.Telephone)],
                Password = "********"
            };
        }

        public static TypeLogement ToTypeLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new TypeLogement()
            {
                IdTypeLogement = (int)record[nameof(TypeLogement.IdTypeLogement)],
                Nom = (string)record[nameof(TypeLogement.Nom)],
                
            };
        }

        public static Adresse ToAdresse(this IDataRecord record)
        {
            if (record is null) return null;
            return new Adresse()
            {
                IdAdresse = (int)record[nameof(Adresse.IdAdresse)],
                Rue = (string)record[nameof(Adresse.Rue)],
                Numero = (string)record[nameof(Adresse.Numero)],
                CodePostal = (string)record[nameof(Adresse.CodePostal)],
                IsoPays = (string)record[nameof(Adresse.IsoPays)],
                Latitude = (double)record[nameof(Adresse.Latitude)],
                Longitude = (double)record[nameof(Adresse.Longitude)],

            };
        }

        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                IdLogement = (int)record[nameof(Logement.IdLogement)],
                Nom = (string)record[nameof(Logement.Nom)],
                DescriptionCourte = (string)record[nameof(Logement.DescriptionCourte)],
                DescriptionLongue = (string)record[nameof(Logement.DescriptionLongue)],
                PrixJournalier = (decimal)record[nameof(Logement.PrixJournalier)],
                NbChambres = (int)record[nameof(Logement.NbChambres)],
                NbPieces = (int)record[nameof(Logement.NbPieces)],
                Capacite = (int)record[nameof(Logement.Capacite)],
                NbSDB = (int)record[nameof(Logement.NbSDB)],
                NbWC = (int)record[nameof(Logement.NbWC)],
                Balcon = (bool)record[nameof(Logement.Balcon)],
                Wifi = (bool)record[nameof(Logement.Wifi)],
                Airco = (bool)record[nameof(Logement.Airco)],
                Minibar = (bool)record[nameof(Logement.Minibar)],
                Animaux = (bool)record[nameof(Logement.Animaux)],
                Piscine = (bool)record[nameof(Logement.Piscine)],
                Voiturier = (bool)record[nameof(Logement.Voiturier)],
                RoomService = (bool)record[nameof(Logement.RoomService)],
                DateAjout = (DateTime)record[nameof(Logement.DateAjout)],
                IdAdresse = (int)record[nameof(Logement.IdAdresse)],
                IdClient = (int)record[nameof(Logement.IdLogement)],
                IdTypeLogement = (int)record[nameof(Logement.IdTypeLogement)]
                

            };
        }
    }


}
