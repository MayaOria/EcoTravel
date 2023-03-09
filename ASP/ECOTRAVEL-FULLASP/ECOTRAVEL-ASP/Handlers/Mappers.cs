using ECOTRAVEL_ASP.Models.ClientViewModels;
using ECOTRAVEL_BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLLEntities = ECOTRAVEL_BLL.Entities;
using DALEntities = ECOTRAVEL_DAL.Entities;

namespace ECOTRAVEL_ASP.Handlers
{
    public static class Mappers
    {
        public static BLLEntities.Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new BLLEntities.Client()
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                IsoPays = entity.IsoPays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {
                Nom = entity.Nom,
                Prenom = entity.Prenom,
                Email = entity.Email,
                IsoPays = entity.IsoPays,
                Telephone = entity.Telephone
                
            };
        }
    }
}
