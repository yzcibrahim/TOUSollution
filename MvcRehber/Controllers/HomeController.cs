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
        public IActionResult Index(string order, string searchBox)
        {
            List<Person> liste = _personRepository.List();
            
             if(order=="name")
                liste = liste.OrderBy(c => c.Name).ToList();
            else if(order=="surname")
                liste = liste.OrderBy(c => c.Surname).ToList();
             else
                liste = liste.OrderBy(c => c.Id).ToList();

             if(!String.IsNullOrEmpty(searchBox))
            {
                // liste = liste.Where(c => c.Name == searchBox || c.Surname==searchBox).ToList();
                //  liste = liste.Where(c => c.Name.Contains(searchBox) || c.Surname.Contains(searchBox)).ToList();
                liste = liste.Where(c => c.Name.StartsWith(searchBox) || c.Surname.StartsWith(searchBox)).ToList();
            }

            List<PersonViewModel> model = new List<PersonViewModel>();
            foreach(var item in liste)
            {
                PersonViewModel pw = new PersonViewModel() { Id = item.Id, Name = item.Name, Phone = item.Phone };
                model.Add(pw);
            }


            return View(model);
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
            //ViewData["valMessages"] = "";
            PersonViewModel model = new PersonViewModel();
            if(id.HasValue && id>0)
            {
                List<Person> people=_personRepository.List();
                var person = people.First(c => c.Id == id);
                model.Id = person.Id;
                model.Name = person.Name;
                model.Phone = person.Phone;
                model.Surname = person.Surname;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
           // ViewBag.valmes = "asdasd";
            //ViewData["valMessages"] = "";
            
            if (!ModelState.IsValid)
            {
                return View(person);
            }

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
