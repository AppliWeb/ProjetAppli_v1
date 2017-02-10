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
    public class parametrageLogsController : Controller
    {
        private appliWebLogsEntities1 db = new appliWebLogsEntities1();

        // GET: parametrageLogs
        public ActionResult Index()
        {
            return View(db.parametrageLogs.ToList());
        }

        // GET: parametrageLogs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageLogs parametrageLogs = db.parametrageLogs.Find(id);
            if (parametrageLogs == null)
            {
                return HttpNotFound();
            }
            return View(parametrageLogs);
        }

        // GET: parametrageLogs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: parametrageLogs/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "libelleServeur,cheminServeur,libelleBatch,identifiantLog,identifiantDomaine,libelleDomaine,identifiantPole,libellePole")] parametrageLogs parametrageLogs)
        {
            if (ModelState.IsValid)
            {
                db.parametrageLogs.Add(parametrageLogs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parametrageLogs);
        }

        // GET: parametrageLogs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageLogs parametrageLogs = db.parametrageLogs.Find(id);
            if (parametrageLogs == null)
            {
                return HttpNotFound();
            }
            return View(parametrageLogs);
        }

        // POST: parametrageLogs/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "libelleServeur,cheminServeur,libelleBatch,identifiantLog,identifiantDomaine,libelleDomaine,identifiantPole,libellePole")] parametrageLogs parametrageLogs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parametrageLogs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parametrageLogs);
        }

        // GET: parametrageLogs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrageLogs parametrageLogs = db.parametrageLogs.Find(id);
            if (parametrageLogs == null)
            {
                return HttpNotFound();
            }
            return View(parametrageLogs);
        }

        // POST: parametrageLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            parametrageLogs parametrageLogs = db.parametrageLogs.Find(id);
            db.parametrageLogs.Remove(parametrageLogs);
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
