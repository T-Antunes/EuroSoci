﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eurosoci.Models;

namespace Eurosoci.Controllers
{
    public class ConcursosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Concursos
        public ActionResult Index()
        {
            var concursos = db.Concursos.Include(c => c.ChaveSorteada);
            return View(concursos.ToList());
        }

        // GET: Concursos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concursos concursos = db.Concursos.Find(id);
            if (concursos == null)
            {
                return HttpNotFound();
            }
            return View(concursos);
        }

        // GET: Concursos/Create
        public ActionResult Create()
        {
            ViewBag.ChaveFK = new SelectList(db.Chaves, "ID", "ID");
            return View();
        }

        // POST: Concursos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DataConcurso,ChaveFK")] Concursos concursos)
        {
            if (ModelState.IsValid)
            {
                db.Concursos.Add(concursos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ChaveFK = new SelectList(db.Chaves, "ID", "ID", concursos.ChaveFK);
            return View(concursos);
        }

        // GET: Concursos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concursos concursos = db.Concursos.Find(id);
            if (concursos == null)
            {
                return HttpNotFound();
            }
            ViewBag.ChaveFK = new SelectList(db.Chaves, "ID", "ID", concursos.ChaveFK);
            return View(concursos);
        }

        // POST: Concursos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DataConcurso,ChaveFK")] Concursos concursos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(concursos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ChaveFK = new SelectList(db.Chaves, "ID", "ID", concursos.ChaveFK);
            return View(concursos);
        }

        // GET: Concursos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Concursos concursos = db.Concursos.Find(id);
            if (concursos == null)
            {
                return HttpNotFound();
            }
            return View(concursos);
        }

        // POST: Concursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Concursos concursos = db.Concursos.Find(id);
            db.Concursos.Remove(concursos);
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
