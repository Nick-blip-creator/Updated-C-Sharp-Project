using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance9.Models;

namespace CarInsurance9.Controllers
{
    public class Insuree9Controller : Controller
    {
        private Insurance9Entities db = new Insurance9Entities();

        // GET: Insuree9
        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees9.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees9 insuree = db.Insurees9.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,")] Insurees9 insuree)
        {
            insuree.Quote = 50;
            TimeSpan age = DateTime.Now - insuree.DateOfBirth;
            int years = Convert.ToInt32(age.TotalDays / 365);
            if (years <= 18)
            {
                insuree.Quote += 100;
            }
            else if (years >= 19 && years <= 25)
            {
                insuree.Quote += 50;
            }
            else
            {
                insuree.Quote += 25;
            }
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                if (insuree.CarModel == "911 Carrera")
                {
                    insuree.Quote += 25;
                }
                insuree.Quote += 25;
            }
            insuree.Quote += insuree.SpeedingTickets * 10;
            if (insuree.DUI)
            {
                insuree.Quote = insuree.Quote + (insuree.Quote * 0.25m);
            }
            if (insuree.CoverageType == true)
            {
                insuree.Quote = insuree.Quote + (insuree.Quote * 0.5m);
            }

            if (ModelState.IsValid)
            {
                db.Insurees9.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees9 insuree = db.Insurees9.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees9 insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insurees9 insuree = db.Insurees9.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insurees9 insuree = db.Insurees9.Find(id);
            db.Insurees9.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            return View(db.Insurees9.ToList());
        }
    }
}
