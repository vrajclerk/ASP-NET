using _5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            // Passing data using ViewData
            ViewData["Message"] = "Welcome to the Student Portal";

            // Passing data using ViewBag
            ViewBag.Author = "Vraj Clerk";

            // Passing an object using ViewData
            ViewData["Student"] = new Student
            {
                Id = 1,
                Name = "John Doe",
                Grade = "A"
            };

            return View();
        }
    }
}