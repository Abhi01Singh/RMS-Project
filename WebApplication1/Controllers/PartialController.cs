using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        private RMSProjectDBContext db = new RMSProjectDBContext();
        public ActionResult Index()
        {
            List<Registration> registrations = db.Registrations.OrderByDescending(x => x.Id).ToList<Registration>();
            return View(registrations);
        }

        [HttpGet]
        public PartialViewResult Create()   //Insert PartialView  
        {
            return PartialView(); //new WebApplication1.Models.Registration()
        }
        [HttpPost]
        public JsonResult Create(Registration reg) // Record Insert  
        {
            RMSProjectDBContext db = new RMSProjectDBContext();
            db.Registrations.Add(reg);
            db.SaveChanges();
            return Json(reg, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public PartialViewResult Edit(Int32 Id)  // Update PartialView  
        {
            RMSProjectDBContext db = new RMSProjectDBContext();
            Registration reg = db.Registrations.Where(x => x.Id == Id).FirstOrDefault();
            Registration registration = new Registration();
            
            registration.Email = reg.Id.ToString();
            registration.Firstname = reg.Firstname;
            registration.Lastname = reg.Lastname;
            registration.Phone = reg.Phone;
            registration.Email = reg.Email;

            return PartialView(registration);
        }

        [HttpPost]
        public JsonResult Edit(Registration registration)  // Record Update 
        {

            RMSProjectDBContext db = new RMSProjectDBContext(); ;
            Registration reg = db.Registrations.Where(x => x.Id == registration.Id).FirstOrDefault();


            reg.Firstname = registration.Firstname;
            reg.Lastname = registration.Lastname;
            reg.Phone = registration.Phone;
            reg.Email = registration.Email;
            db.SaveChanges();

            return Json(reg, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(Int32 Id)
        {
            Registration reg = db.Registrations.Where(x => x.Id == Id).FirstOrDefault();
            db.Registrations.Remove(reg);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}