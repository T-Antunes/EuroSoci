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
    public class ChavesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Chaves
        public ActionResult Index()
        {
            var chaves = db.Chaves.Include(c => c.TipoChave);
            return View(chaves.ToList());
        }

        // GET: Chaves/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chaves chaves = db.Chaves.Find(id);
            if (chaves == null)
            {
                return HttpNotFound();
            }
            return View(chaves);
        }

        // GET: Chaves/Create
        public ActionResult Create()
        {
            var TodosNumeros = db.Numeros
                .OrderBy(n => n.EEstrela)
                .ThenBy(n => n.Valor)
                .ToList();

            ViewBag.TodosNumeros = TodosNumeros;
            
            ViewBag.TipoChaveFK = new SelectList(db.TipoChaves, "ID", "Tipo");
            return View();
        }

        // POST: Chaves/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Preco,TipoChaveFK")] Chaves chaves, int[] numerosIds)
        {
            if (numerosIds == null || numerosIds.Length == 0)
            {
                ModelState.AddModelError("", "Seleccione números e estrelas.");
            }
            else
            {
                // Temos números...
                var todosNumeros = db.Numeros.Where(n => numerosIds.Contains(n.ID)).ToList();

                var numeros = todosNumeros.Where(n => n.EEstrela == false).ToList();
                var estrelas = todosNumeros.Where(n => n.EEstrela == true).ToList();

                if(numeros.Count <5 || numeros.Count > 11 || estrelas.Count <2 || estrelas.Count > 12)
                {
                    ModelState.AddModelError("", "Seleccione o número correcto de números e estrelas");

                }
                else
                {
                    chaves.ListaNumeros = todosNumeros;
                }
            }

            if (ModelState.IsValid)
            {
                db.Chaves.Add(chaves);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            var TodosNumeros = db.Numeros
                .OrderBy(n => n.EEstrela)
                .ThenBy(n => n.Valor)
                .ToList();

            ViewBag.TodosNumeros = TodosNumeros;

            ViewBag.TipoChaveFK = new SelectList(db.TipoChaves, "ID", "Tipo", chaves.TipoChaveFK);
            return View(chaves);
        }

        // GET: Chaves/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chaves chaves = db.Chaves.Find(id);
            if (chaves == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoChaveFK = new SelectList(db.TipoChaves, "ID", "Tipo", chaves.TipoChaveFK);
            return View(chaves);
        }

        // POST: Chaves/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Preco,TipoChaveFK")] Chaves chaves)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chaves).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoChaveFK = new SelectList(db.TipoChaves, "ID", "Tipo", chaves.TipoChaveFK);
            return View(chaves);
        }

        // GET: Chaves/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chaves chaves = db.Chaves.Find(id);
            if (chaves == null)
            {
                return HttpNotFound();
            }
            return View(chaves);
        }

        // POST: Chaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Chaves chaves = db.Chaves.Find(id);
            db.Chaves.Remove(chaves);
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
