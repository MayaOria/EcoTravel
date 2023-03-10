using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface IGetRepository<TEntity, TId>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);
    }
}
