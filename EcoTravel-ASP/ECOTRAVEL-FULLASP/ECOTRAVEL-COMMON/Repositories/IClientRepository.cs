using ECOTRAVEL_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_COMMON.Repositories
{
    public interface IClientRepository<TEntity, TId> : 
        IInsertRepository<TEntity, TId>,
        IGetByIdRepository<TEntity, TId>,
        IUpdateRepository<TEntity, TId>
        where TEntity : IClient
    {
        
        int? CheckLogin(string email, string password);
    }
}
