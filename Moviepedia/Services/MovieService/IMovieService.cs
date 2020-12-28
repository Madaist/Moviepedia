using Moviepedia.DTOs;
using System.Collections.Generic;

namespace Moviepedia.Services.MovieService
{
    public interface IMovieService
    {
        public MovieDTO GetMovie(string movieId);
        public ICollection<MovieDTO> GetAll();
        public bool Delete(string movieId);
        public bool Update(UpdateMovieDTO movieDTO);
    }
}
