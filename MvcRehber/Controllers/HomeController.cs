using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcRehber.Helpers;
using MvcRehber.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IRepositoryPerson _reopsitory = Repositoryfactory.CreateRepo("PERSON");

            List<Person> liste = _reopsitory.List();
            return View(liste);
            #region MyRegion
            //KisiTest mdl = new KisiTest();
            //mdl.Ad = "ibrahim";
            //mdl.Soyad = "yazıcı";
            //return View(mdl); 
            #endregion
        }
        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            IRepositoryPerson repositoryPerson = Repositoryfactory.CreateRepo("PERSON");
            repositoryPerson.AddOrUpdate(person);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy(KisiTest kisi)
        {
           

            return View(kisi);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
