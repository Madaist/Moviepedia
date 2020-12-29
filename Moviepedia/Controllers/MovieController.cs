using Microsoft.AspNetCore.Mvc;
using Moviepedia.DTOs;
using Moviepedia.Services.MovieService;

namespace Moviepedia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_movieService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(string id)
        {
            var movie = _movieService.GetMovie(id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound(new { message = "Movie not found" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(string id)
        {
            var deleteSuccessfull = _movieService.Delete(id);
            if (deleteSuccessfull)
            {
                return Ok(new { message = "Movie deleted successfully" });
            }
            return BadRequest(new { message = "Movie not found" });
        }

        [HttpPut]
        public IActionResult UpdateMovie(UpdateMovieDTO movieDTO)
        {
            if (_movieService.Update(movieDTO))
            {
                return Ok();
            }
            return NotFound(new { message = "Movie not found" });
        }

        [HttpPost]
        public IActionResult CreateMovie(PostMovieDTO movieDTO)
        {
            _movieService.Create(movieDTO);
            return Ok();
        }
    }
}
