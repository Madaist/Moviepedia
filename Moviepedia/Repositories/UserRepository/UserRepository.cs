using Moviepedia.Data;
using Moviepedia.Models;
using Moviepedia.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationUser GetByUsernameAndPassword(string username, string password)
        {
            return _table.Where(x => x.UserName == username && x.PasswordHash == password).FirstOrDefault();
        }
    }
}
