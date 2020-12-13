using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<ApplicationUser>
    {
        ApplicationUser GetByUsernameAndPassword(string username, string password);
    }
}
