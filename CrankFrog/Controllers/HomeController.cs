using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrankFrog.DAL;
using CrankFrog.Models;

namespace CrankFrog.Controllers
{
    public class HomeController : Controller
    {
        private PersonContext db = new PersonContext();

        public ActionResult Index()
        {
            var model = new AppModel();
            model.People = db.People.ToList();
            return View(model);
        }
        
        public JsonResult AutoCompleteSearch(string term)
        {
            var result = (from r in db.People
                          where r.Name.ToLower().Contains(term.ToLower())
                          select new { r.Name }).Distinct();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}