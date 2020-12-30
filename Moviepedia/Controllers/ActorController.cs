using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moviepedia.DTOs;
using Moviepedia.Services.ActorService;

namespace Moviepedia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        [HttpPost]
        public IActionResult Create(ActorDTO actorDTO)
        {
            _actorService.Create(actorDTO);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_actorService.GetAll());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActor(string id)
        {
            var deleteSuccessfull = _actorService.Delete(id);
            if (deleteSuccessfull)
            {
                return Ok(new { message = "Actor deleted successfully" });
            }
            return BadRequest(new { message = "Actor not found" });
        }

        [HttpPut]
        public IActionResult UpdateActor(ActorDTO actorDTO)
        {
            if (_actorService.Update(actorDTO))
            {
                return Ok();
            }
            return NotFound(new { message = "Actor not found" });
        }

        [HttpGet("{id}")]
        public IActionResult GeActor(string id)
        {
            var actor = _actorService.GetById(id);
            if (actor != null)
            {
                return Ok(actor);
            }
            return NotFound(new { message = "Actor not found" });
        }
    }
}
