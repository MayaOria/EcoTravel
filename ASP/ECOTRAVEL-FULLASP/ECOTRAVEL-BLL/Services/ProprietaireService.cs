using ECOTRAVEL_BLL.Entities;
using ECOTRAVEL_BLL.Mappers;
using ECOTRAVEL_COMMON.Entities;
using ECOTRAVEL_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALEntities = ECOTRAVEL_DAL.Entities;

namespace ECOTRAVEL_BLL.Services
{
    public class ProprietaireService : IProprietaireRepository<Proprietaire, int>
    {
        #region Injection de dépendance (repositories)
        //Ajouter le service du logement quand il sera créé
        //Ajouter le service de la réservation quand il sera créé
        private readonly IProprietaireRepository<DALEntities.Proprietaire, int> _repository;

        public ProprietaireService(IProprietaireRepository<DALEntities.Proprietaire, int> repository)
        {
            _repository = repository;
        }
        #endregion
        public int? CheckLogin(string email, string password)
        {
            return _repository.CheckLogin(email, password);
        }

        public Proprietaire Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public IEnumerable<Proprietaire> GetByIdLogement(int idLogement)
        {
            return _repository.GetByIdLogement(idLogement).Select(e => e.ToBLL());
        }

        public int Insert(Proprietaire entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(Proprietaire entity, int id)
        {
            return _repository.Update(entity.ToDAL(), id);
        }
    }
}
