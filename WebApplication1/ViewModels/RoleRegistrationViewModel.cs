using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class RoleRegistrationViewModel
    {
        public List<RoleModel> Roles { get; set; }

        public Registration registrationData { get; set; }
    }
}