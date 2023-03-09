using ECOTRAVEL_BLL.Entities;
using ECOTRAVEL_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_BLL.Services
{
    public class ClientService : IClientRepository<Client, int>
    {
        private readonly IClientRepository<>
        int? IClientRepository<Client, int>.CheckLogin(string email, string password)
        {
            throw new NotImplementedException();
        }

        Client IGetByIdRepository<Client, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        int IInsertRepository<Client, int>.Insert(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
