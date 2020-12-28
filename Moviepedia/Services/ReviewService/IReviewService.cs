using Moviepedia.DTOs;

namespace Moviepedia.Services.ReviewService
{
    public interface IReviewService
    {
        public bool Create(string userId, PostReviewDTO postReview);
    }
}
