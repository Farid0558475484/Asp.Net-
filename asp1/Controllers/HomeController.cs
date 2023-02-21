using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp1.Models;
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

            var students = GetStudents();
            return View(students);
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
    }
}