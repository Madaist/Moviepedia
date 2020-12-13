using Moviepedia.DTOs;
using System.Collections.Generic;

namespace Moviepedia.Services.ActorService
{
    public interface IActorService
    {
        public ICollection<ActorDTO> GetActorsByMovie(string movieId);
    }
}
