using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RMSDBcontext : DbContext
    {
        public RMSDBcontext() : base("RMS")
        {

        }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RoleModel> Role { get; set; }

        public DbSet<UserRoleReg> UserRole { get; set; }
    }
}