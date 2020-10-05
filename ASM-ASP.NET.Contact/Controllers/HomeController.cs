using ASM.ASP.NET.Models;
using ASM.ASP.NET.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASM.ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        SolutionEntitiesDbContext db = new SolutionEntitiesDbContext();
        public HomeController()
        {
            
        }
        public ActionResult Index()
        {
            var data = db.Contacts.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}