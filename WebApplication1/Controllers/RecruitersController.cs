using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RecruitersController : Controller
    {
        private RMSDBcontext db = new RMSDBcontext();

        // GET: Recruiters
        public ActionResult Index()
        {
            var recruiter = db.recruiter.Include(r => r.UserRole);
            return View(recruiter.ToList());
        }

        // GET: Recruiters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recruiter recruiter = db.recruiter.Find(id);
            if (recruiter == null)
            {
                return HttpNotFound();
            }
            return View(recruiter);
        }

        // GET: Recruiters/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.UserRole, "Id", "RoleName");
            return View();
        }

        // POST: Recruiters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,Firstname,Lastname,Phone,Email,Id")] Recruiter recruiter)
        {
            if (ModelState.IsValid)
            {
                db.recruiter.Add(recruiter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.UserRole, "Id", "RoleName", recruiter.Id);
            return View(recruiter);
        }

        // GET: Recruiters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recruiter recruiter = db.recruiter.Find(id);
            if (recruiter == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.UserRole, "Id", "RoleName", recruiter.Id);
            return View(recruiter);
        }

        // POST: Recruiters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Firstname,Lastname,Phone,Email,Id")] Recruiter recruiter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recruiter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.UserRole, "Id", "RoleName", recruiter.Id);
            return View(recruiter);
        }

        // GET: Recruiters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recruiter recruiter = db.recruiter.Find(id);
            if (recruiter == null)
            {
                return HttpNotFound();
            }
            return View(recruiter);
        }

        // POST: Recruiters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recruiter recruiter = db.recruiter.Find(id);
            db.recruiter.Remove(recruiter);
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
