﻿using System;
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
    }
}
