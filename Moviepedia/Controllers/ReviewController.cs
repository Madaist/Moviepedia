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
    }
}
