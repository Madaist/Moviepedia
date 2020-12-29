using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.ReviewRepository;
using System;
using System.Collections.Generic;

namespace Moviepedia.Services.ReviewService
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }
        public bool Create(string userId, PostReviewDTO reviewDTO)
        {
            bool isCreated = true;
            if(reviewDTO == null || userId == null)
            {
                isCreated = false;
                return isCreated;
            }
            Review review = new Review
            {
                Id = Guid.NewGuid().ToString(),
                MovieId = reviewDTO.MovieId,
                UserId = userId,
                Content = reviewDTO.Content
            };
            _reviewRepository.Create(review);
            return isCreated;
        }

        public IEnumerable<Review> GetAll()
        {
            return _reviewRepository.GetAll();
        }

        public bool Delete(string reviewId)
        {
            var review = _reviewRepository.FindById(reviewId);
            if (review != null)
            {
                _reviewRepository.Delete(review);
                return true;
            }
            return false;
        }

        public bool Update(UpdateReviewDTO reviewDTO)
        {
            bool isUpdated = true;
            var review = _reviewRepository.FindById(reviewDTO.Id);
            if(review == null)
            {
                isUpdated = false;
                return isUpdated;
            }
            review.Content = reviewDTO.Content;
            _reviewRepository.Update(review);
            return isUpdated;
        }
    }
}
