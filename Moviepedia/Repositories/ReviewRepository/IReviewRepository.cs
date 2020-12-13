using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Repositories.ReviewRepository
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        public IEnumerable<Review> FindByUserId(string userId);
        public IEnumerable<Review> FindByMovieId(string movieId);
    }
}
