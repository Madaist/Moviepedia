using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Moviepedia.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
