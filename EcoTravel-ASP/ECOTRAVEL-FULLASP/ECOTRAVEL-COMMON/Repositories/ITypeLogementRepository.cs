using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface ITypeLogementRepository<TEntity, TId> :
        IInsertRepository<TEntity, TId>,
        IGetRepository<TEntity, TId>
        where TEntity : ITypeLogement
    {
    }
}
