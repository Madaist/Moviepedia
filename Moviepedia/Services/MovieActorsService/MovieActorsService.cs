using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.ActorRepository;
using Moviepedia.Repositories.MovieActorsRepository;
using Moviepedia.Repositories.MovieRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Moviepedia.Services.MovieActorsService
{
    public class MovieActorsService: IMovieActorsService
    {
        private readonly IMovieActorsRepository _movieActorsRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorRepository;
        public MovieActorsService(IMovieActorsRepository movieActorsRepository, IMovieRepository movieRepository, IActorRepository actorRepository)
        {
            _movieActorsRepository = movieActorsRepository;
            _movieRepository = movieRepository;
            _actorRepository = actorRepository;
        }

        public bool CreateMovieActor(MovieActorsDTO movieActorsDTO)
        {
            bool isCreated = true;
            var movie = _movieRepository.FindById(movieActorsDTO.MovieId);
            var actor = _actorRepository.FindById(movieActorsDTO.ActorId);
            if(movie == null || actor == null)
            {
                isCreated = false;
                return isCreated;
            }
            var movieActors = _movieActorsRepository.FindByMovieIdAndActorId(movieActorsDTO.MovieId, movieActorsDTO.ActorId);
            if (movieActors.Count() >= 1)
            {
                throw new Exception("Actor already exists for this movie");
            }
            MovieActors movieActor = new MovieActors
            {
                Id = Guid.NewGuid().ToString(),
                MovieId = movieActorsDTO.MovieId,
                ActorId = movieActorsDTO.ActorId
            };
            _movieActorsRepository.Create(movieActor);
            return isCreated;

        }
    }
}
