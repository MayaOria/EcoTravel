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
    public class LogementService : ILogementRepository<Logement, int>
    {
        #region Injection de dépendance (repositories)
        //Ajouter le service de l'adresse, du proprietaire et du TypedeLogement
        private readonly ILogementRepository<DALEntities.Logement, int> _repository;
        

        public LogementService(ILogementRepository<DALEntities.Logement, int> repository)
        {
            _repository = repository;
        }
        #endregion
        public IEnumerable<Logement> Get()
        {
            throw new NotImplementedException();
        }

        public Logement Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Logement> GetByIdAdresse(int idAdresse)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Logement> GetByIdProprietaire(int idProprietaire)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Logement> GetByIdTypeLogement(int idTypeLogement)
        {
            throw new NotImplementedException();
        }

        public int Insert(Logement entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(Logement entity, int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
