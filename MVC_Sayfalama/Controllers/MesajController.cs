using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using MVC_Sayfalama.Models;
using System.Data.Entity;


namespace MVC_Sayfalama.Controllers
{

    public class MesajController : Controller
    {
        private mvcPagelistContex db = new mvcPagelistContex();

        int gostericekSayfaSayisi;
        // GET: Mesaj
        public ViewResult Index(int? page)
        {
            int pageIndex = page ?? 1;
            gostericekSayfaSayisi = 5;

            var result = db.mesajs.OrderByDescending(x => x.id).ToPagedList(pageIndex, gostericekSayfaSayisi);

            return View(result);
        }
        //Arama ile detay
        public ViewResult Details(int id)
        {
            mesaj mesaj = db.mesajs.Find(id);
            return View(mesaj);
        }

        // GET: /mesaj/Create

        public ActionResult Create()
        {
            return View();
        }


        // POST: /mesaj/Create

        [HttpPost]
        public ActionResult Create(mesaj mesaj)
        {
            if (ModelState.IsValid)
            {
                db.mesajs.Add(mesaj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mesaj);
        }

        // GET: /mesaj/Edit/5

        public ActionResult Edit(int id)
        {
            mesaj mesaj = db.mesajs.Find(id);
            return View(mesaj);
        }

        //
        // POST: /mesaj/Edit/5

        [HttpPost]
        public ActionResult Edit(mesaj mesaj)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mesaj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mesaj);
        }

        // GET: /mesaj/Delete/5

        public ActionResult Delete(int id)
        {
            mesaj mesaj = db.mesajs.Find(id);
            return View(mesaj);
        }

        //
        // POST: /mesaj/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            mesaj mesaj = db.mesajs.Find(id);
            db.mesajs.Remove(mesaj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }



    }
}