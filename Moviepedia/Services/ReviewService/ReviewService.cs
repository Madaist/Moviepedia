using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.ReviewRepository;
using System;

namespace Moviepedia.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public bool Create(string userId, PostReviewDTO postReview)
        {
            bool isCreated = true;
            if(postReview == null || userId == null)
            {
                isCreated = false;
                return isCreated;
            }
            Review review = new Review
            {
                Id = Guid.NewGuid().ToString(),
                MovieId = postReview.MovieId,
                UserId = userId,
                Content = postReview.Content
            };
            _reviewRepository.Create(review);
            return isCreated;
        }
    }
}
