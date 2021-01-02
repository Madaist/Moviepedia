using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moviepedia.DTOs;
using Moviepedia.Services.MovieActorsService;
using System;

namespace Moviepedia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MovieActorsController : ControllerBase
    {
        private readonly IMovieActorsService _movieActorsService;

        public MovieActorsController(IMovieActorsService movieActorsService)
        {
            _movieActorsService = movieActorsService;
        }

        [HttpPost]
        public IActionResult Create(MovieActorsDTO movieActor)
        {
            try
            {
                if (_movieActorsService.CreateMovieActor(movieActor))
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception )
            {
                return BadRequest("Actor already exists for this movie");
            }

        }
    }
}
