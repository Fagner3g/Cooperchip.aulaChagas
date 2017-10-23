using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cooperchip.aulaChagas.Dados.Contexto;
using Cooperchip.aulaChagas.Dados.Modelos;

namespace Cooperchip.aulaChagas.Web.Controllers
{
    public class TipoTelefoneController : Controller
    {
        private DadosContext db = new DadosContext();

        // GET: TipoTelefone
        public ActionResult Index()
        {
            return View(db.TipoTelefone.ToList());
        }

        // GET: TipoTelefone/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTelefone tipoTelefone = db.TipoTelefone.Find(id);
            if (tipoTelefone == null)
            {
                return HttpNotFound();
            }
            return View(tipoTelefone);
        }

        // GET: TipoTelefone/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTelefone/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTelefoneId,Descricao")] TipoTelefone tipoTelefone)
        {
            if (ModelState.IsValid)
            {
                db.TipoTelefone.Add(tipoTelefone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTelefone);
        }

        // GET: TipoTelefone/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTelefone tipoTelefone = db.TipoTelefone.Find(id);
            if (tipoTelefone == null)
            {
                return HttpNotFound();
            }
            return View(tipoTelefone);
        }

        // POST: TipoTelefone/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTelefoneId,Descricao")] TipoTelefone tipoTelefone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoTelefone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTelefone);
        }

        // GET: TipoTelefone/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTelefone tipoTelefone = db.TipoTelefone.Find(id);
            if (tipoTelefone == null)
            {
                return HttpNotFound();
            }
            return View(tipoTelefone);
        }

        // POST: TipoTelefone/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTelefone tipoTelefone = db.TipoTelefone.Find(id);
            db.TipoTelefone.Remove(tipoTelefone);
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
