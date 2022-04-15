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
        IRepositoryPerson _personRepository;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _personRepository = Repositoryfactory.CreateRepo("PERSON");
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Person> liste = _personRepository.List();
            return View(liste);
            #region MyRegion
            //KisiTest mdl = new KisiTest();
            //mdl.Ad = "ibrahim";
            //mdl.Soyad = "yazıcı";
            //return View(mdl); 
            #endregion
        }
        [HttpGet]
        public IActionResult CreatePerson(int? id)
        {
            Person model = new Person();
            if(id.HasValue && id>0)
            {
                List<Person> people=_personRepository.List();
                model = people.First(c => c.Id == id);
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            _personRepository.AddOrUpdate(person);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _personRepository.Delete(id);
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
