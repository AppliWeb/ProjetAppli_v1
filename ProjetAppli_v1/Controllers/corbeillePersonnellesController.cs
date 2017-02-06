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
    public class corbeillePersonnellesController : Controller
    {
        private appliWebLogsEntities1 db = new appliWebLogsEntities1();

        // GET: corbeillePersonnelles
        public ActionResult Index()
        {
            ViewBag.NomPage = "Corbeille Personnelle";
            ViewBag.statut = new SelectList(db.statut, "libelle", "libelle");
            return View(db.corbeillePersonnelle.ToList());
        }

        // GET: corbeillePersonnelles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            corbeillePersonnelle corbeillePersonnelle = db.corbeillePersonnelle.Find(id);
            if (corbeillePersonnelle == null)
            {
                return HttpNotFound();
            }
            return View(corbeillePersonnelle);
        }

        // GET: corbeillePersonnelles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: corbeillePersonnelles/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "identifiant,fkIdentifiantLog,dateCreation,nom,numeroEtape,messageErreur,severite,datePriseEnCharge,dateTraitement,statut,detailAnomalie")] corbeillePersonnelle corbeillePersonnelle)
        {
            if (ModelState.IsValid)
            {
                db.corbeillePersonnelle.Add(corbeillePersonnelle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(corbeillePersonnelle);
        }

        // GET: corbeillePersonnelles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            corbeillePersonnelle corbeillePersonnelle = db.corbeillePersonnelle.Find(id);
            if (corbeillePersonnelle == null)
            {
                return HttpNotFound();
            }
            return View(corbeillePersonnelle);
        }

        // POST: corbeillePersonnelles/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "identifiant,fkIdentifiantLog,dateCreation,nom,numeroEtape,messageErreur,severite,datePriseEnCharge,dateTraitement,statut,detailAnomalie")] corbeillePersonnelle corbeillePersonnelle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(corbeillePersonnelle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(corbeillePersonnelle);
        }

        // GET: corbeillePersonnelles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            corbeillePersonnelle corbeillePersonnelle = db.corbeillePersonnelle.Find(id);
            if (corbeillePersonnelle == null)
            {
                return HttpNotFound();
            }
            return View(corbeillePersonnelle);
        }

        // POST: corbeillePersonnelles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            corbeillePersonnelle corbeillePersonnelle = db.corbeillePersonnelle.Find(id);
            db.corbeillePersonnelle.Remove(corbeillePersonnelle);
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
