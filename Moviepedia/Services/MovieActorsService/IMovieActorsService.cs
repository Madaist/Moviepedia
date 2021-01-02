using Moviepedia.DTOs;

namespace Moviepedia.Services.MovieActorsService
{
    public interface IMovieActorsService
    {
        public bool CreateMovieActor(MovieActorsDTO movieActorsDTO);
    }
}
