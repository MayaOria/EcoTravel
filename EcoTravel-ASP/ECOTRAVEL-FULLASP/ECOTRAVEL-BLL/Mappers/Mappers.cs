using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLEntities = ECOTRAVEL_BLL.Entities;
using DALEntities = ECOTRAVEL_DAL.Entities;

namespace ECOTRAVEL_BLL.Mappers
{
    public static class Mappers
    {
        public static BLLEntities.Client ToBLL(this DALEntities.Client entity)
        {
            if (entity is null) return null;
            return new BLLEntities.Client()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                IsoPays = entity.IsoPays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static DALEntities.Client ToDAL(this BLLEntities.Client entity)
        {
            if (entity is null) return null;
            return new DALEntities.Client()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                IsoPays = entity.IsoPays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static BLLEntities.Proprietaire ToBLL(this DALEntities.Proprietaire entity)
        {
            if (entity is null) return null;
            return new BLLEntities.Proprietaire()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                IsoPays = entity.IsoPays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static DALEntities.Proprietaire ToDAL(this BLLEntities.Proprietaire entity)
        {
            if (entity is null) return null;
            return new DALEntities.Proprietaire()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                IsoPays = entity.IsoPays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static BLLEntities.TypeLogement ToBLL(this DALEntities.TypeLogement entity)
        {
            if (entity is null) return null;
            return new BLLEntities.TypeLogement()
            {
                IdTypeLogement = entity.IdTypeLogement,
                Nom = entity.Nom
                
            };
        }

        public static DALEntities.TypeLogement ToDAL(this BLLEntities.TypeLogement entity)
        {
            if (entity is null) return null;
            return new DALEntities.TypeLogement()
            {
                IdTypeLogement = entity.IdTypeLogement,
                Nom = entity.Nom
                
            };
        }
        public static BLLEntities.Adresse ToBLL(this DALEntities.Adresse entity)
        {
            if (entity is null) return null;
            return new BLLEntities.Adresse()
            {
                IdAdresse = entity.IdAdresse,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                IsoPays = entity.IsoPays,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude

            };
        }

        public static DALEntities.Adresse ToDAL(this BLLEntities.Adresse entity)
        {
            if (entity is null) return null;
            return new DALEntities.Adresse()
            {
                IdAdresse = entity.IdAdresse,
                Rue = entity.Rue,
                Numero = entity.Numero,
                CodePostal = entity.CodePostal,
                IsoPays = entity.IsoPays,
                Latitude = entity.Latitude,
                Longitude = entity.Longitude

            };
        }

        public static DALEntities.Logement ToDAL(this BLLEntities.Logement entity)
        {
            if (entity is null) return null;
            return new DALEntities.Logement()
            {
                IdLogement = entity.IdLogement,
                Nom = entity.Nom,
                DescriptionCourte = entity.DescriptionCourte,
                DescriptionLongue = entity.DescriptionLongue,
                PrixJournalier = entity.PrixJournalier,
                NbChambres = entity.NbChambres,
                NbPieces = entity.NbPieces,
                Capacite = entity.Capacite,
                NbSDB = entity.NbSDB,
                NbWC = entity.NbWC,
                Balcon = entity.Balcon,
                Wifi = entity.Wifi,
                Airco = entity.Airco,
                Minibar = entity.Minibar,
                Animaux = entity.Animaux,
                Piscine = entity.Piscine,
                Voiturier = entity.Voiturier,
                RoomService = entity.RoomService,
                IdAdresse = entity.IdAdresse,
                IdClient = entity.IdClient,
                DateAjout = entity.DateAjout,
                IdTypeLogement = entity.IdTypeLogement
            };
        }
    }
}
