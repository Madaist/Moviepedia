using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.ActorRepository;
using Moviepedia.Repositories.MovieActorsRepository;
using System.Collections.Generic;
using System.Linq;

namespace Moviepedia.Services.ActorService
{
    public class ActorService : IActorService
    {
        private readonly IMovieActorsRepository _movieActorsRepository;
        private readonly IActorRepository _actorRepository;

        public ActorService(IMovieActorsRepository movieActorsRepository, IActorRepository actorRepository)
        {
            _movieActorsRepository = movieActorsRepository;
            _actorRepository = actorRepository;
        }
        public ICollection<ActorDTO> GetActorsByMovie(string movieId)
        {
            //daca vad ca nu DTO-ul ramane identic cu entitatea, nu mai folosesc ActorDTO
            //ca sa nu mai fac transformari degeaba
            ICollection<ActorDTO> actorsDTO = new List<ActorDTO>();
            var movieActors = _movieActorsRepository.FindByMovieId(movieId);
            if (movieActors != null & movieActors.Any())
            {
                foreach (MovieActors movieActor in movieActors)
                {
                    var actor = _actorRepository.FindById(movieActor.ActorId);
                    ActorDTO actorDTO = new ActorDTO
                    {
                        Id = actor.Id,
                        LastName = actor.LastName,
                        FirstName = actor.FirstName,
                        Age = actor.Age,
                        Picture = actor.Picture
                    };
                    actorsDTO.Add(actorDTO);
                }
            }
            return actorsDTO;
        }
    }
}
