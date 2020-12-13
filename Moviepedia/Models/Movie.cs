using System.Collections.Generic;

namespace Moviepedia.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string MovieInfoId { get; set; }
        public string Picture { get; set; }
       
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual MovieInfo MovieInfo { get; set; }
        public virtual ICollection<MovieActors> MovieActors { get; set;}

    }
}
