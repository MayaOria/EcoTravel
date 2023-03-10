using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface IGetAllRepository<TEntity, TId>
    {
        IEnumerable<TEntity> Get();
        
    }
}
