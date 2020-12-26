using Moviepedia.Models;
using System.Collections.Generic;

namespace Moviepedia.DTOs
{
    public class MovieDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string StoryLine { get; set; }
        public int ReleaseYear { get; set; }
        public string Category { get; set; }
        public string BoxOffice { get; set; }
        public  IEnumerable<Review> Reviews { get; set; }
        public  ICollection<ActorDTO> Actors { get; set; }

    }
}
