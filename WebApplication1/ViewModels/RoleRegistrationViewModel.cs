using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class RoleRegistrationViewModel
    {
        public List<ChkRoleModel> ChkRoles { get; set; }

        public Registration registrationData { get; set; }

        public Recruiter recruiter { get; set; }
    }

    public class ChkRoleModel
    {
        public string Text { get; set; }

        public int Value { get; set; }

        public bool Selected { get; set; }
    }
}