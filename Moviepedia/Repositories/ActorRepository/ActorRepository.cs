using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;

namespace Moviepedia.Repositories.ActorRepository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
