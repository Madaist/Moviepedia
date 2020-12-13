using Moviepedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.DTOs
{
    public class MovieDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public  IEnumerable<Review> Reviews { get; set; }
        public  MovieInfoDTO MovieInfo { get; set; }
        public  ICollection<ActorDTO> Actors { get; set; }

    }
}
