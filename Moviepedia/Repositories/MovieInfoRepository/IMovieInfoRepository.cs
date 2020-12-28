using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;

namespace Moviepedia.Repositories.MovieInfoRepository
{
    public interface IMovieInfoRepository : IGenericRepository<MovieInfo>
    {
        public MovieInfo FindByMovieId(string movieId);
    }
}
