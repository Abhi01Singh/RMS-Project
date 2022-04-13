using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Recruiter
    {
        [Key]
        public int UserId { get; set; }

        public string Firstname { get; set; }

        
        public string Lastname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        //[EmailAddress]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
                   ErrorMessage = "Entered Email format is not valid.")]
        public string Email { get; set; }
        
        public int Id { get; set; }

        [ForeignKey("Id")]
        public virtual UserRoleReg UserRole { get; set; }

    }
}