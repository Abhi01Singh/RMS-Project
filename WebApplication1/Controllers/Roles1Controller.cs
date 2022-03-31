/*using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Roles1Controller : Controller
    {
        // GET: Roles1
        RMSProjectDBContext context;

        public Roles1Controller()
        {
            context = new RMSProjectDBContext();
        }

        /// <summary>
        /// Get All Roles
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        /// <summary>
        /// Create  a New role
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var Role = new RoleModel1();
            return View(Role);
        }

        /// <summary>
        /// Create a New Role
        // </summary>
        // <param name="Role"></param>
        // <returns></returns>
        [HttpPost]
        public ActionResult Create(RoleModel1 Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
*/


 