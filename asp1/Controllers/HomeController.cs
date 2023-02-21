using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp1.Models;
using asp1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            ViewData["Name"] = "Farid";
            ViewBag.Surname = GetStudents();
          
            TempData["25"] = 25;
            //return Content("hello");
            //return Json(new{
            //    name="Farid",
            //    age=25
            //});
            //return File("~/img/lorem.jpeg", "image/jpeg");

            //var students = GetStudents();
            //var groups = GetGroup();

            //HomeVW homeVW = new HomeVW();
            //homeVW.Students = GetStudents();
            //homeVW.Groups = GetGroup();

            //return View(homeVW);

            //return View();

            return RedirectToAction("About");
        }


        public IActionResult About()
        {
            return View();
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1,Name="Farid",Surname="Hacizade"});
            students.Add(new Student() { Id = 2, Name = "Elnar", Surname = "Memmedov" });
            students.Add(new Student() { Id = 2, Name = "Togrul", Surname = "Gurbanli" });
            return students;
        }


        private List<Group> GetGroup()
        {
            List<Group> groups = new List<Group>();
            groups.Add(new Group() { Id = 1, Name = "Group1"});
            groups.Add(new Group() { Id = 2, Name = "Group2" });
            groups.Add(new Group() { Id = 2, Name = "Group3", });
            return groups;
        }
    }
}