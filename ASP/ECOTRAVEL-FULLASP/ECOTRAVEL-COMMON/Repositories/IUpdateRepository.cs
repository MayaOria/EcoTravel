using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface IUpdateRepository<TId, TEntity>
    {
        bool Update(TId id, TEntity entity);
    }
}
