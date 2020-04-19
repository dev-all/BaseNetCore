
using Microsoft.AspNetCore.Identity;
using Models.Auth;
using System.Collections.Generic;

namespace FrontEnd.Models
{
    public class RoleEdit
    {
        public ApplicationRole Role { get; set; }
        public IEnumerable<ApplicationUser> Members { get; set; }
        public IEnumerable<ApplicationUser> NonMembers { get; set; }
    }
}
