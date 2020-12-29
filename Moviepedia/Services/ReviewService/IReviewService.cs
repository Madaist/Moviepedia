using Moviepedia.DTOs;
using Moviepedia.Models;
using System.Collections.Generic;

namespace Moviepedia.Services.ReviewService
{
    public interface IReviewService
    {
        public bool Create(string userId, PostReviewDTO reviewDTO);
        public IEnumerable<Review> GetAll();
        public bool Delete(string reviewId);
        public bool Update(UpdateReviewDTO reviewDTO);
    }
}
