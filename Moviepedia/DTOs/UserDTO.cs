using Moviepedia.Models;
using System.Collections.Generic;

namespace Moviepedia.DTOs
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  ICollection<Review> Reviews { get; set; }
    }
}
