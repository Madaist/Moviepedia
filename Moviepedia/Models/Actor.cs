using System.Collections.Generic;

namespace Moviepedia.Models
{
    public class Actor
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<MovieActors> MovieActors { get; set; }

    }
}
