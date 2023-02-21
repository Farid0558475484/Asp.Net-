using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id, string name)
        {
            //return Content("hello");
            //return Json(new{
            //    name="Farid",
            //    age=25
            //});
            //return File("~/img/lorem.jpeg", "image/jpeg");


            return View();
        }


        public IActionResult About()
        {
            return View();
        }
    }
}