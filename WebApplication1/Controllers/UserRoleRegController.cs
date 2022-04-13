using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    
    public class UserRoleRegController : Controller
    {
        private RMSDBcontext db = new RMSDBcontext();

        // GET: UserRoleReg

        [Authorize(Roles = "Administrator")]
        
        public ActionResult Index()
        {
            if (Session["Email"] != null)
            {
                var userRole = db.UserRole.Include(u => u.Registration).Include(u => u.RoleModel);

                return View(userRole.ToList());
            }
            else
            {
                return RedirectToAction("Login");
            }
           
        }

        // GET: UserRoleReg/Details/5
        //[Authorize(Roles = "Administrator")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRoleReg userRoleReg = db.UserRole.Find(id);
            if (userRoleReg == null)
            {
                return HttpNotFound();
            }
            return View(userRoleReg);
        }

        // GET: UserRoleReg/Create
        public ActionResult Create()
        {
            /*ViewBag.UserId = new SelectList(db.Registrations, "Id", "Firstname");
            ViewBag.RoleModelId = new SelectList(db.Role, "Id", "RoleName");
            return View();*/
            IEnumerable<SelectListItem>
    TypeDropDown = db.Registrations.Select(x => new SelectListItem
    {
        Text = x.Firstname,
        Value = x.Id.ToString()
    });
            IEnumerable<SelectListItem>
                TypeDropDown2 = db.Role.Select(x => new SelectListItem
                {
                    Text = x.RoleName,
                    Value = x.Id.ToString()
                });

            ViewBag.TypeDropDown = TypeDropDown;
            ViewBag.TypeDropDown2 = TypeDropDown2;
            return View();


        }

        // POST: UserRoleReg/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RoleModelId,UserId,UserName,RoleName")] UserRoleReg userRoleReg)
        {
            if (ModelState.IsValid)
            {
                db.UserRole.Add(userRoleReg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Registrations, "Id", "Firstname", userRoleReg.UserId);
            ViewBag.RoleModelId = new SelectList(db.Role, "Id", "RoleName", userRoleReg.RoleModelId);
            return View(userRoleReg);
        }

        // GET: UserRoleReg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRoleReg userRoleReg = db.UserRole.Find(id);
            if (userRoleReg == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Registrations, "Id", "Firstname", userRoleReg.UserId);
            ViewBag.RoleModelId = new SelectList(db.Role, "Id", "RoleName", userRoleReg.RoleModelId);
            return View(userRoleReg);
        }

        // POST: UserRoleReg/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RoleModelId,UserId,UserName,RoleName")] UserRoleReg userRoleReg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRoleReg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Registrations, "Id", "Firstname", userRoleReg.UserId);
            ViewBag.RoleModelId = new SelectList(db.Role, "Id", "RoleName", userRoleReg.RoleModelId);
            return View(userRoleReg);
        }

        // GET: UserRoleReg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRoleReg userRoleReg = db.UserRole.Find(id);
            if (userRoleReg == null)
            {
                return HttpNotFound();
            }
            return View(userRoleReg);
        }

        // POST: UserRoleReg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRoleReg userRoleReg = db.UserRole.Find(id);
            db.UserRole.Remove(userRoleReg);
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
