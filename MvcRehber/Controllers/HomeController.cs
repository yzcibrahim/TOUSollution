using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public IActionResult Index()
        {
            List<KisiTest> liste = new List<KisiTest>();
            liste.Add(new KisiTest() { Soyad = "yazıcı", Ad = "ibrahim" });
            liste.Add(new KisiTest() { Soyad = "asd", Ad = "asd" });
            liste.Add(new KisiTest() { Soyad = "fsderfg", Ad = "wrg" });
            return View(liste);
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
