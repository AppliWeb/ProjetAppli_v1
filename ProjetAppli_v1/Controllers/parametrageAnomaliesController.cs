using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetAppli_v1.Models;

namespace ProjetAppli_v1.Controllers
{
    public class parametrageAnomaliesController : Controller
    {
        private appliWebLogsEntities1 db = new appliWebLogsEntities1();

        // GET: parametrageAnomalies
        public ActionResult Index()
        {
            return View(db.parametrageAnomalie.ToList());
        }

        // GET: parametrageAnomalies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageAnomalie parametrageAnomalie = db.parametrageAnomalie.Find(id);
            if (parametrageAnomalie == null)
            {
                return HttpNotFound();
            }
            return View(parametrageAnomalie);
        }

        // GET: parametrageAnomalies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: parametrageAnomalies/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "identifiant,severite,type,messageErreur,phraseExclue,statut")] parametrageAnomalie parametrageAnomalie)
        {
            if (ModelState.IsValid)
            {
                db.parametrageAnomalie.Add(parametrageAnomalie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parametrageAnomalie);
        }

        // GET: parametrageAnomalies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageAnomalie parametrageAnomalie = db.parametrageAnomalie.Find(id);
            if (parametrageAnomalie == null)
            {
                return HttpNotFound();
            }
            return View(parametrageAnomalie);
        }

        // POST: parametrageAnomalies/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "identifiant,severite,type,messageErreur,phraseExclue,statut")] parametrageAnomalie parametrageAnomalie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parametrageAnomalie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parametrageAnomalie);
        }

        // GET: parametrageAnomalies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageAnomalie parametrageAnomalie = db.parametrageAnomalie.Find(id);
            if (parametrageAnomalie == null)
            {
                return HttpNotFound();
            }
            return View(parametrageAnomalie);
        }

        // POST: parametrageAnomalies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            parametrageAnomalie parametrageAnomalie = db.parametrageAnomalie.Find(id);
            db.parametrageAnomalie.Remove(parametrageAnomalie);
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
    }
}
