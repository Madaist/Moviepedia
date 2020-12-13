using Moviepedia.DTOs;

namespace Moviepedia.Services.MovieService
{
    public interface IMovieService
    {
        public MovieDTO GetMovieInfo(string movieId);
    }
}
