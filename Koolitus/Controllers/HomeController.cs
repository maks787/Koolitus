using Koolitus.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koolitus.Controllers
{
    public class HomeController : Controller
    {
        KoolitusContext db = new KoolitusContext();
        [Authorize(Users = "admin@gmail.com")]
        public ActionResult Koolitused()
        {
            IEnumerable<koolitused> kolituss = db.Koolituss;
            return View(kolituss);
        }
        [Authorize(Users = "admin@gmail.com")]
        public ActionResult Lapsv()
        {
            IEnumerable<Laps> Lapss = db.Lapss;
            return View(Lapss);
        }
        [Authorize(Users = "admin@gmail.com")]
        public ActionResult Opetaja()
        {
            IEnumerable<Opetaja> opetajas = db.Opetajas;
            return View(opetajas);
        }
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
        [HttpGet]
        public ActionResult Koolitusedс()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Koolitusedс(koolitused koolitus)
        {
            if (ModelState.IsValid)
            {
                db.Koolituss.Add(koolitus);
                db.SaveChanges();
                return RedirectToAction("Koolitused");
            }
            return View(koolitus);
        }
        [HttpGet]
        public ActionResult KoolitusedD(int id)
        {
            koolitused g = db.Koolituss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("KoolitusedD")]
        public ActionResult DeleteConfirmed(int id)
        {
            koolitused g = db.Koolituss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            db.Koolituss.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            koolitused g = db.Koolituss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditConfirmed(koolitused koolitus)
        {
            db.Entry(koolitus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Koolitused");
        }
        [HttpGet]
        public ActionResult LapsC()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LapsC(Laps laps)
        {
            if (ModelState.IsValid)
            {
                db.Lapss.Add(laps);
                db.SaveChanges();
                return RedirectToAction("Lapsv");
            }
            return View(laps);
        }
        [HttpGet]
        public ActionResult LapsD(int id)
        {
            Laps g = db.Lapss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("LapsD")]
        public ActionResult DeleteConfirmedL(int id)
        {
            Laps l = db.Lapss.Find(id);
            if (l == null)
            {
                return HttpNotFound();
            }
            db.Lapss.Remove(l);
            db.SaveChanges();
            return RedirectToAction("Lapsv");
        }
        [HttpGet]
        public ActionResult LapsE(int? id)
        {
            Laps l = db.Lapss.Find(id);
            if (l == null)
            {
                return HttpNotFound();
            }
            return View(l);
        }
        [HttpPost, ActionName("LapsE")]
        public ActionResult EditConfirmedL(Laps laps)
        {
            db.Entry(laps).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Lapsv");
        }
        [HttpGet]
        public ActionResult OpetajaC()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OpetajaC(Opetaja opetaja)
        {
            if (ModelState.IsValid)
            {
                db.Opetajas.Add(opetaja);
                db.SaveChanges();
                return RedirectToAction("Opetaja");
            }
            return View(opetaja);
        }
        [HttpGet]
        public ActionResult OpetajaD(int id)
        {
            Opetaja o = db.Opetajas.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }
        [HttpPost, ActionName("OpetajaD")]
        public ActionResult DeleteConfirmedO(int id)
        {
            Opetaja o = db.Opetajas.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            db.Opetajas.Remove(o);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }
        [HttpGet]
        public ActionResult OpetajaE(int? id)
        {
            Opetaja o = db.Opetajas.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }
        [HttpPost, ActionName("OpetajaE")]
        public ActionResult EditConfirmedO(Opetaja opetaja)
        {
            db.Entry(opetaja).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }
    }
}