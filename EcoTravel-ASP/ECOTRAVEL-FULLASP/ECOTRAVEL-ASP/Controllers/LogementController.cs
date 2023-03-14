using ECOTRAVEL_ASP.Handlers;
using ECOTRAVEL_ASP.Models.LogementViewModels;
using ECOTRAVEL_BLL.Entities;
using ECOTRAVEL_COMMON.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECOTRAVEL_ASP.Controllers
{
    public class LogementController : Controller
    {

        private readonly ILogementRepository<Logement, int> _services;
        private readonly IProprietaireRepository<Proprietaire, int> _servicesProprietaire;
        private readonly IClientRepository<Client, int> _servicesClient;
        private readonly ITypeLogementRepository<TypeLogement, int> _servicesTypeLogement;
        private readonly SessionManager _sessionManager;

        public LogementController(ILogementRepository<Logement, int> services,
                ITypeLogementRepository<TypeLogement, int> servicesTypeLogement,            IClientRepository<Client, int> servicesClient,
                                    SessionManager sessionManager,
                                    IProprietaireRepository<Proprietaire, int> servicesProprietaire)
        {
            _services = services;
            _sessionManager = sessionManager;
            _servicesTypeLogement = servicesTypeLogement;
            _servicesProprietaire = servicesProprietaire;
        }

        // GET: LogementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LogementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogementController/Create
        public ActionResult Create()
        {
            
            LogementCreateForm model = new LogementCreateForm();
            model.IdClient = _sessionManager.CurrentUser.IdUser;
            return View(model);
        }

        // POST: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogementCreateForm model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

           
            else
            {
                
                
                    Client client = _servicesClient.Get(model.IdClient);
                    Proprietaire proprietaire = new Proprietaire()
                    {
                        IdClient = client.IdClient,
                        Nom = client.Nom,
                        Prenom = client.Prenom,
                        IsoPays = client.IsoPays,
                        Telephone = client.Telephone,
                        Email = client.Email,
                        Password = client.Password
                    };

                
                    _servicesProprietaire.Insert(proprietaire);
                
                int id = _services.Insert(model.ToBLL());
                return RedirectToAction("Details", "Logement", new { id = id });
            }
        }

        // GET: LogementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
