using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRehber.Controllers
{
    public class TestController : Controller
    {
        Test _tst;
        public TestController(Test tst)
        {
            _tst = tst;
        }
        public IActionResult Index()
        {
            return Json("Ad:ibrahim");
        }
    }
}
