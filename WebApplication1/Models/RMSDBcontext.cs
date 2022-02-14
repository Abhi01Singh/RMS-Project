using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RMSDBcontext : DbContext
    {
        public RMSDBcontext() : base("RMSconnections")
        {

        }
        public DbSet<Registration> Registrations { get; set; }
    }
}