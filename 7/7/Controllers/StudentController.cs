using _7.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult Create()
        {
            return View();
        }
        // READ: Get Method for Details
        public ActionResult Details(int id)
        {
            var student = db.Students.FirstOrDefault(s => s.StudentID == id); // LINQ Query
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();

                // Redirect to the Index page after successful edit
                return RedirectToAction("Index");
            }

            return View(student);  // If the model state is invalid, return the view with the current student data
        }

        // CREATE: Post Method
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // READ: Get Method for Listing
        public ActionResult Index()
        {
            var students = db.Students.ToList(); // LINQ Query
            return View(students);
        }
        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();

            // Redirect to the Index page after successful deletion
            return RedirectToAction("Index");
        }

    }
}