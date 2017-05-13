using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaInventario.DAL;
using SistemaInventario.Models;

namespace SistemaInventario.Controllers
{
    public class RegistroSparesController : Controller
    {
        private InventarioDB db = new InventarioDB();

        // GET: RegistroSpares
        public ActionResult Index()
        {
            return View(db.Spare.ToList());
        }

        // GET: RegistroSpares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroSpare registroSpare = db.Spare.Find(id);
            if (registroSpare == null)
            {
                return HttpNotFound();
            }
            return View(registroSpare);
        }

        // GET: RegistroSpares/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroSpares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpareID,Nombre,NumeroParte,SerialNumero,Almacen,Fecha")] RegistroSpare registroSpare)
        {
            if (ModelState.IsValid)
            {
                db.Spare.Add(registroSpare);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registroSpare);
        }

        // GET: RegistroSpares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroSpare registroSpare = db.Spare.Find(id);
            if (registroSpare == null)
            {
                return HttpNotFound();
            }
            return View(registroSpare);
        }

        // POST: RegistroSpares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpareID,Nombre,NumeroParte,SerialNumero,Almacen,Fecha")] RegistroSpare registroSpare)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registroSpare).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registroSpare);
        }

        // GET: RegistroSpares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroSpare registroSpare = db.Spare.Find(id);
            if (registroSpare == null)
            {
                return HttpNotFound();
            }
            return View(registroSpare);
        }

        // POST: RegistroSpares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroSpare registroSpare = db.Spare.Find(id);
            db.Spare.Remove(registroSpare);
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
