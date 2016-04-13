using SimpleDatabase2.DataContent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleDatabase2.Controllers
{
    public class HomeController : Controller
    {
        private SimpleDatabaseDB db = new SimpleDatabaseDB();

        public ActionResult Index()
        {
            return View();
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