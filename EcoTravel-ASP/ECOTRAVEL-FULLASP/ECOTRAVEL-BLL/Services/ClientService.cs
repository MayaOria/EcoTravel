using ECOTRAVEL_BLL.Entities;
using ECOTRAVEL_BLL.Mappers;
using ECOTRAVEL_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEntities = ECOTRAVEL_DAL.Entities;

namespace ECOTRAVEL_BLL.Services
{
    public class ClientService : IClientRepository<Client, int>
    {
        #region Injection de dépendance (repositories)
        private readonly IClientRepository<DALEntities.Client, int> _repository;

        public ClientService(IClientRepository<DALEntities.Client, int> repository)
        {
            _repository = repository;
        }
        #endregion

        public int? CheckLogin(string email, string password)
        {
            return _repository.CheckLogin(email, password);
        }

        public Client Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Client entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(Client entity, int id)
        {
            return _repository.Update(entity.ToDAL(), id);
        }
    }
}
