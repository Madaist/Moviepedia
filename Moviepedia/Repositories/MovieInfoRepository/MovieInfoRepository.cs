using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;

namespace Moviepedia.Repositories.MovieInfoRepository
{
    public class MovieInfoRepository : GenericRepository<MovieInfo>, IMovieInfoRepository
    {
        public MovieInfoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
