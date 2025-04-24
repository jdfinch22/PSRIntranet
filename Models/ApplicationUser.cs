using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PSRIntranet.Models
{
    public class Class
    {
        public class ApplicationUser : IdentityUser
        {
             public virtual required ICollection<Event> Events { get; set; }
        }
    }
}
