using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface ILogementRepository<TEntity, TId> :
        IGetRepository<TEntity, TId>,
        IInsertRepository<TEntity, TId>,
        IUpdateRepository<TEntity, TId>
        where TEntity : ILogement
    {
        IEnumerable<TEntity> GetByIdTypeLogement(TId idTypeLogement);
        IEnumerable<TEntity> GetByIdProprietaire(TId idProprietaire);
        IEnumerable<TEntity> GetByIdAdresse(TId idAdresse);

        //+ getBy filtres (piscine, airco, etc.) ?
    }
}
