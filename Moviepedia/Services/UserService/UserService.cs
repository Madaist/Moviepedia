using Moviepedia.DTOs;
using Moviepedia.Models;
using Moviepedia.Repositories.ReviewRepository;
using Moviepedia.Repositories.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IReviewRepository _reviewRepository;

        public UserService(IUserRepository userRepository, IReviewRepository reviewRepository)
        {
            _userRepository = userRepository;
            _reviewRepository = reviewRepository;
        }
        public UserDTO GetUserInfo(string userId)
        {
            ApplicationUser user = _userRepository.FindById(userId);
            UserDTO userDTO = new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Reviews = (ICollection<Review>)_reviewRepository.FindByUserId(userId)
            };
            return userDTO;
        }
    }
}
