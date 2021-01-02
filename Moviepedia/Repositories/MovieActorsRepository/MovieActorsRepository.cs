using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Repositories.MovieActorsRepository
{
    public class MovieActorsRepository : GenericRepository<MovieActors>, IMovieActorsRepository
    {
        public MovieActorsRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<MovieActors> FindByMovieId(string movieId)
        {
            return  GetAll().Where(x => x.MovieId == movieId);
        }

        public IQueryable<MovieActors> FindByMovieIdAndActorId(string movieId, string actorId)
        {
            return _context.MovieActors.Where(x => x.MovieId == movieId && x.ActorId == actorId);
        }
    }
}
