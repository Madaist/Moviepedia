using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System.Collections.Generic;
using System.Linq;

namespace Moviepedia.Repositories.ReviewRepository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Review> FindByUserId(string userId)
        {
            return GetAll().Where(x => x.UserId == userId);
        }

        public IEnumerable<Review> FindByMovieId(string movieId)
        {
            return GetAll().Where(x => x.MovieId == movieId);
        }
    }
}
