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
    public class TypeLogementService : ITypeLogementRepository<TypeLogement, int>
    {
        #region Injection de dépendance (repositories)
        
        private readonly ITypeLogementRepository<DALEntities.TypeLogement, int> _repository;

        public TypeLogementService(ITypeLogementRepository<DALEntities.TypeLogement, int> repository)
        {
            _repository = repository;
        }
        #endregion

        public IEnumerable<TypeLogement> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public TypeLogement Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(TypeLogement entity)
        {
            return _repository.Insert(entity.ToDAL());
        }
    }
}
