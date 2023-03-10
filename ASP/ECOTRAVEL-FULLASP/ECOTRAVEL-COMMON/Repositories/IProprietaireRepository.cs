using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface IProprietaireRepository<TEntity, TId>
        : IClientRepository<TEntity, TId>
        where TEntity : IProprietaire
    {
        IEnumerable<TEntity> GetByIdLogement(TId idLogement);
        //IEnumerable<TEntity> GetByIdReservation(Tid idReservation);
    }
}
