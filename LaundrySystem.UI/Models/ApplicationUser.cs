using Microsoft.AspNetCore.Identity;
using System;

namespace LaundrySystem.UI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }        
        public bool IsAdmin { get; set; }
        public string Picture { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
