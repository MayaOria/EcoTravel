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
        private readonly ITypeLogementRepository<TypeLogement, int> _servicesTypeLogement;
        private readonly SessionManager _sessionManager;

        public LogementController(ILogementRepository<Logement, int> services,
                ITypeLogementRepository<TypeLogement, int> servicesTypeLogement,            
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
            //Je n'ai pas réussi à faire le cast pour que cela fonctionne...
            //model.typeLogement = (List<TypeLogement>)_servicesTypeLogement.Get();
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
                model.IdClient = _sessionManager.currentUser.IdUser;
                if(_servicesProprietaire.Get(model.IdClient) is null)
                {
                    //Creer le proprietaire
                }
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
