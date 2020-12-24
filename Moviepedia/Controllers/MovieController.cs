using Microsoft.AspNetCore.Mvc;
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
            else
            {
                return NotFound(new { message = "Movie not found" });
            }
        }
    }
}
