using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.MovieInfoRepository;
using Moviepedia.Repositories.MovieRepository;
using Moviepedia.Repositories.ReviewRepository;
using Moviepedia.Services.ActorService;
using System.Collections.Generic;
using System.Linq;

namespace Moviepedia.Services.MovieService
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IReviewRepository _reviewRepository;
        private readonly IMovieInfoRepository _movieInfoRepository;
        private readonly IActorService _actorService;

        public MovieService(IMovieRepository movieRepository, IReviewRepository reviewRepository, IMovieInfoRepository movieInfoRepository, IActorService actorService)
        {
            _movieRepository = movieRepository;
            _reviewRepository = reviewRepository;
            _movieInfoRepository = movieInfoRepository;
            _actorService = actorService;
        }
        public MovieDTO GetMovie(string movieId)
        {
            Movie movie = _movieRepository.FindById(movieId);
            if (movie != null)
            {
                MovieInfo movieInfo = _movieInfoRepository.FindById(movie.MovieInfoId);
                MovieDTO movieDTO = new MovieDTO
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Picture = movie.Picture,
                    BoxOffice = movieInfo.BoxOffice,
                    Category = movieInfo.Category,
                    ReleaseYear = movieInfo.ReleaseYear,
                    StoryLine = movieInfo.StoryLine,
                    Reviews = _reviewRepository.FindByMovieId(movieId),
                    Actors = _actorService.GetActorsByMovie(movieId)
                };

                return movieDTO;
            }
            else
            {
                return null;
            }
        }

        //public MovieInfoDTO GetMovieInfoDTO(string movieId)
        //{
        //    Movie movie = _movieRepository.FindById(movieId);
        //    var movieInfo = _movieInfoRepository.FindById(movie.MovieInfoId);
        //    MovieInfoDTO movieInfoDTO = new MovieInfoDTO
        //    {
        //        Id = movieInfo.Id,
        //        BoxOffice = movieInfo.BoxOffice,
        //        Category = movieInfo.Category,
        //        ReleaseYear = movieInfo.ReleaseYear,
        //        StoryLine = movieInfo.StoryLine
        //    };
        //    return movieInfoDTO;
        //}

        public ICollection<MovieDTO> GetAll()
        {
            IEnumerable<string> movieIds = _movieRepository.GetAll().Select(x => x.Id);
            ICollection<MovieDTO> moviesDTO = new List<MovieDTO>();
            foreach (string movieId in movieIds)
            {
                MovieDTO movieDTO = GetMovie(movieId);
                moviesDTO.Add(movieDTO);
            }
            return moviesDTO;
        }

        public bool Delete(string movieId)
        {
            var movie = _movieRepository.FindById(movieId);
            if(movie != null)
            {
                _movieRepository.Delete(movie);
                return true;
            }
            return false;
        }

        public bool Update(UpdateMovieDTO movieDTO)
        {
            bool isUpdated = true;
            Movie movie = _movieRepository.FindById(movieDTO.Id);
            if (movie != null)
            {
                movie.Picture = movieDTO.Picture;
                movie.Title = movieDTO.Title;

                var movieInfo = _movieInfoRepository.FindByMovieId(movie.Id);
                movieInfo.BoxOffice = movieDTO.BoxOffice;
                movieInfo.Category = movieDTO.Category;
                movieInfo.ReleaseYear = movieDTO.ReleaseYear;

                _movieRepository.Update(movie);
                _movieInfoRepository.Update(movieInfo);
                return isUpdated;
            }
            else
            {
                isUpdated = false;
                return isUpdated;
            }
           
        }
    }
}
