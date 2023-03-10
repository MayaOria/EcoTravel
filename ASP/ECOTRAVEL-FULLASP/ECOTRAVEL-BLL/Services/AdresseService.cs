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
    public class AdresseService : IAdresseRepository<Adresse, int>
    {
        #region Injection de dépendance (repositories)

        private readonly IAdresseRepository<DALEntities.Adresse, int> _repository;

        public AdresseService(IAdresseRepository<DALEntities.Adresse, int> repository)
        {
            _repository = repository;
        }
        #endregion
        public IEnumerable<Adresse> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Adresse Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Adresse entity)
        {
            return _repository.Insert(entity.ToDAL());
        }
    }
}
