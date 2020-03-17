using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MasterLayoutEx.Models;

namespace MasterLayoutEx.Controllers
{
    public class EMPDATAsController : Controller
    {
        private DemoEntities db = new DemoEntities();

        // GET: EMPDATAs
        public ActionResult Index()
        {
            return View(db.EMPDATAs.ToList());
        }

        // GET: EMPDATAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPDATA eMPDATA = db.EMPDATAs.Find(id);
            if (eMPDATA == null)
            {
                return HttpNotFound();
            }
            return View(eMPDATA);
        }

        // GET: EMPDATAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPDATAs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO")] EMPDATA eMPDATA)
        {
            if (ModelState.IsValid)
            {
                db.EMPDATAs.Add(eMPDATA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMPDATA);
        }

        // GET: EMPDATAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPDATA eMPDATA = db.EMPDATAs.Find(id);
            if (eMPDATA == null)
            {
                return HttpNotFound();
            }
            return View(eMPDATA);
        }

        // POST: EMPDATAs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMPNO,ENAME,JOB,MGR,HIREDATE,SAL,COMM,DEPTNO")] EMPDATA eMPDATA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPDATA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMPDATA);
        }

        // GET: EMPDATAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPDATA eMPDATA = db.EMPDATAs.Find(id);
            if (eMPDATA == null)
            {
                return HttpNotFound();
            }
            return View(eMPDATA);
        }

        // POST: EMPDATAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPDATA eMPDATA = db.EMPDATAs.Find(id);
            db.EMPDATAs.Remove(eMPDATA);
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
