using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moviepedia.DTOs;
using Moviepedia.Services.ReviewService;
using System.Security.Claims;

namespace Moviepedia.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]PostReviewDTO postReview)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var isCreated =_reviewService.Create(userId, postReview);
            if (isCreated)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_reviewService.GetAll());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReview(string id)
        {
            var deleteSuccessfull = _reviewService.Delete(id);
            if (deleteSuccessfull)
            {
                return Ok(new { message = "Review deleted successfully" });
            }
            return BadRequest(new { message = "Review not found" });
        }

        public IActionResult UpdateReview(UpdateReviewDTO reviewDTO)
        {
            if (_reviewService.Update(reviewDTO))
            {
                return Ok();
            }
            return NotFound(new { message = "Review not found" });
        }
    }
}
