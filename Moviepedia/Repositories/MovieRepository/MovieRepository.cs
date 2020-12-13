using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;

namespace Moviepedia.Repositories.MovieRepository
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
