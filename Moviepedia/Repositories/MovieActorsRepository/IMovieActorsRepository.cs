using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Repositories.MovieActorsRepository
{
    public interface IMovieActorsRepository : IGenericRepository<MovieActors>
    {
        public IEnumerable<MovieActors> FindByMovieId(string movieId);
        public IQueryable<MovieActors> FindByMovieIdAndActorId(string movieId, string actorId);
    }
}
