using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6.Models;

namespace _6.Controllers
{
    public class StudentController : Controller
    {
        private SchoolDbContext db = new SchoolDbContext();
        // GET: Student
        public ActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }
    }
}