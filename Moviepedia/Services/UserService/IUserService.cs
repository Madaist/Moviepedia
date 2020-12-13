using Moviepedia.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Services.UserService
{
    public interface IUserService
    {
        public UserDTO GetUserInfo(string userId);
    }
}
