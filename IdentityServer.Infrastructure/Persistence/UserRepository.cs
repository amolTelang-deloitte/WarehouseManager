using IdentityServer.Applcation.Common.Interfaces.Persistence;
using IdentityServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _userRepository = new();



        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _userRepository.SingleOrDefault(u => u.Email == email);
        }
    }
}
