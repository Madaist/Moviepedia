using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;

namespace Moviepedia.Repositories.MovieRepository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
