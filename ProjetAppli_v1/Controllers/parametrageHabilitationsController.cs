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
    public class parametrageHabilitationsController : Controller
    {
        private appliWebLogsEntities1 db = new appliWebLogsEntities1();

        // GET: parametrageHabilitations
        public ActionResult Index()
        {
            return View(db.parametrageHabilitations.ToList());
        }

        // GET: parametrageHabilitations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageHabilitations parametrageHabilitations = db.parametrageHabilitations.Find(id);
            if (parametrageHabilitations == null)
            {
                return HttpNotFound();
            }
            return View(parametrageHabilitations);
        }

        // GET: parametrageHabilitations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: parametrageHabilitations/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "identifiant,debutValidite,finValidite,nom,prenom,email,motDePasse,role,domaines")] parametrageHabilitations parametrageHabilitations)
        {
            if (ModelState.IsValid)
            {
                db.parametrageHabilitations.Add(parametrageHabilitations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parametrageHabilitations);
        }

        // GET: parametrageHabilitations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageHabilitations parametrageHabilitations = db.parametrageHabilitations.Find(id);
            if (parametrageHabilitations == null)
            {
                return HttpNotFound();
            }
            return View(parametrageHabilitations);
        }

        // POST: parametrageHabilitations/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "identifiant,debutValidite,finValidite,nom,prenom,email,motDePasse,role,domaines")] parametrageHabilitations parametrageHabilitations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parametrageHabilitations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parametrageHabilitations);
        }

        // GET: parametrageHabilitations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageHabilitations parametrageHabilitations = db.parametrageHabilitations.Find(id);
            if (parametrageHabilitations == null)
            {
                return HttpNotFound();
            }
            return View(parametrageHabilitations);
        }

        // POST: parametrageHabilitations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            parametrageHabilitations parametrageHabilitations = db.parametrageHabilitations.Find(id);
            db.parametrageHabilitations.Remove(parametrageHabilitations);
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
