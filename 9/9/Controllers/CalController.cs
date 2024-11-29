using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _9.Models;

namespace _9.Controllers
{
    public class CalController : Controller
    {
        // GET: Cal
        public ActionResult Index()
        {
            ViewBag.Operations = new SelectList(new[] { "Add", "Subtract", "Multiply", "Divide" });
            return View(new Cal());
        }
        [HttpPost]
        public ActionResult Index(Cal model)
        {
            if (ModelState.IsValid)
            {
                switch (model.Operation)
                {
                    case "Add":
                        model.Result = model.Number1 + model.Number2;
                        break;
                    case "Subtract":
                        model.Result = model.Number1 - model.Number2;
                        break;
                    case "Multiply":
                        model.Result = model.Number1 * model.Number2;
                        break;
                    case "Divide":
                        model.Result = model.Number2 != 0 ? model.Number1 / model.Number2 : double.NaN;
                        break;
                }
            }

            ViewBag.Operations = new SelectList(new[] { "Add", "Subtract", "Multiply", "Divide" }, model.Operation);
            return View(model);
        }
    }
}