using IdentityServer.Applcation.Common.Interfaces.Authentication;
using IdentityServer.Applcation.Common.Interfaces.Persistence;
using IdentityServer.Applcation.Interfaces;
using IdentityServer.Applcation.Response;
using IdentityServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Applcation.Services
{
    public class AuthenticationService : IAuthenticationService
    {

        private readonly IJwtGenerator _jwtGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtGenerator jwtGenerator, IUserRepository userRepository)
        {
            _jwtGenerator = jwtGenerator;
            _userRepository = userRepository;
        }
        public AuthenticationResponse Register(string firstName, string lastName, string email, string password)
        {
            //check if user already exists
            if (_userRepository.GetUserByEmail(email) != null)
            {
                throw new Exception("user with given email already exists");
            }

            //create new user 
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
            _userRepository.Add(user);



            var token = _jwtGenerator.GenerateToken(user.Id, firstName, lastName);

            return new AuthenticationResponse(user.Id, firstName, lastName, email, token);
        }

        public AuthenticationResponse Login(string email, string password)
        {

            //validte the user exists
            if (_userRepository.GetUserByEmail(email) is not User user)
            {
                throw new Exception("invalid credentials");
            }
            //validate password is correct
            if (user.Password != password)
            {
                throw new Exception("Invalid Credentials");
            }

            //create jwt token
            var token = _jwtGenerator.GenerateToken(user.Id, user.FirstName, user.LastName);

            return new AuthenticationResponse(user.Id, user.FirstName, user.LastName, email, token);

        }
    }
}
