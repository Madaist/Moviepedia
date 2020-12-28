using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System.Linq;

namespace Moviepedia.Repositories.MovieInfoRepository
{
    public class MovieInfoRepository : GenericRepository<MovieInfo>, IMovieInfoRepository
    {
        public MovieInfoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public MovieInfo FindByMovieId(string movieId)
        {
            Movie movie = _context.Movies.Find(movieId);
            MovieInfo movieInfo = _context.MovieInfos.Find(movie.MovieInfoId);
            return movieInfo;
        }
    }
}
