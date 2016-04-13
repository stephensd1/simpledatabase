using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleDatabase2.Models;
using SimpleDatabase2.DataContent;

namespace SimpleDatabase2.Controllers
{
    public class DonorController : Controller
    {
        private SimpleDatabaseDB db = new SimpleDatabaseDB();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //
        // GET: /Donor/
        public ActionResult Donor()
        {
            return View(db.Donor.ToList());
        }

        public ActionResult CreateDonor()
        {
            return ViewDonor();
        }

        [HttpPost]
        public ActionResult CreateDonor(Donor Donor)
        {
            db.Donor.Add(Donor);
            db.SaveChanges();
            return RedirectToAction("Donor");
        }

        public ActionResult ViewDonor(int id = 0)
        {
            Donor Donor = db.Donor.Find(id);
            if (Donor == null)
            {
                return HttpNotFound();
            }
            return View(Donor);
        }


        public ActionResult EditDonor(int id = 0)
        {
            Donor Donor = db.Donor.Find(id);
            if (Donor == null)
            {
                return HttpNotFound();
            }
            return View(Donor);
        }

        [HttpPost]
        public ActionResult EditDonor(Donor Donor)
        {
            db.Entry(Donor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Donor");


        }

        public ActionResult DeleteDonor(int id = 0)
        {
            Donor Donor = db.Donor.Find(id);
            if (Donor == null)
            {
                return HttpNotFound();
            }
            return View(Donor);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Donor Donor = db.Donor.Find(id);
            db.Donor.Remove(Donor);
            db.SaveChanges();
            return RedirectToAction("Donor");
        }

        


    }
}