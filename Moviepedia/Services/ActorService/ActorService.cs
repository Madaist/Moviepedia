using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.ActorRepository;
using Moviepedia.Repositories.MovieActorsRepository;
using System;
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

        public void Create(ActorDTO actorDTO)
        {
            Actor actor = new Actor
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = actorDTO.FirstName,
                LastName = actorDTO.LastName,
                Picture = actorDTO.Picture,
                Age = actorDTO.Age
            };
            _actorRepository.Create(actor);
        }

        public IEnumerable<Actor> GetAll()
        {
            return _actorRepository.GetAll();
        }

        public bool Delete(string actorId)
        {
            var actor = _actorRepository.FindById(actorId);
            if(actor != null)
            {
                _actorRepository.Delete(actor);
                return true;
            }
            return false;
        }

        public bool Update(ActorDTO actorDTO)
        {
            var isUpdated = true;
            Actor actor = _actorRepository.FindById(actorDTO.Id);
            if(actor == null)
            {
                isUpdated = false;
                return isUpdated;
            }
            actor.LastName = actorDTO.LastName;
            actor.FirstName = actorDTO.FirstName;
            actor.Age = actorDTO.Age;
            actor.Picture = actorDTO.Picture;

            _actorRepository.Update(actor);
            return isUpdated;
        }
    }
}
