using ECOTRAVEL_ASP.Handlers;
using ECOTRAVEL_ASP.Models.ClientViewModels;
using ECOTRAVEL_BLL.Entities;
using ECOTRAVEL_COMMON.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_ASP.Controllers
{
    public class ClientController : Controller
    {
        #region injection de dépendances (services)
        private readonly IClientRepository<Client, int> _services;
        // GET: ClientController

        public ClientController(IClientRepository<Client, int> services)
        {
            _services = services;
        }
        #endregion

        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            
            ClientDetails model = _services.Get(id).ToDetails();
            if (model is null) return null;
            return View(model);
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientCreateForm form)
        {
            if(!ModelState.IsValid)
            {
                form.Password = null;
                form.ConfirmPass = null;
                return View();
            }

            else
            {
                int id = _services.Insert(form.ToBLL());
                return RedirectToAction("Details", new { id = id });
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        
    }
}
