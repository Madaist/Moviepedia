using Moviepedia.DTOs;
using Moviepedia.Models;
using System.Collections.Generic;

namespace Moviepedia.Services.ActorService
{
    public interface IActorService
    {
        public ICollection<ActorDTO> GetActorsByMovie(string movieId);
        public void Create(ActorDTO actorDTO);
        public bool Delete(string actorId);
        public IEnumerable<Actor> GetAll();
        public bool Update(ActorDTO actorDTO);
        public Actor GetById(string actorId);
    }
}
