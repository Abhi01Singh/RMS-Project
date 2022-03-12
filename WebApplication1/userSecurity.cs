using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1
{
    public class userSecurity
    {
        public static bool Login(string Email, String Password)
        {
            using (Models.RMSProjectDBContext db = new RMSProjectDBContext())
            {
                return db.Registrations.Any(r => r.Email.Equals(Email, StringComparison.OrdinalIgnoreCase) && r.Password == Password);
            }
        }
    }
}