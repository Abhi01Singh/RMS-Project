using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserRoleReg
    {
        [Key]
        public int Id { get; set; }

        public int RoleModelId { get; set; }

        public string RoleName { get; set; }

        public int UserId { get; set; }

        [ForeignKey("RoleModelId")]
        public virtual RoleModel RoleModel { get; set; }


        [ForeignKey("UserId")]
        public virtual Registration Registration { get; set; }
    }
}