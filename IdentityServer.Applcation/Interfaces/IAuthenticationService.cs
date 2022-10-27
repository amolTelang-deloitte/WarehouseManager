using IdentityServer.Applcation.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Applcation.Interfaces
{
    public interface IAuthenticationService
    {
        AuthenticationResponse Register(string firstName, string lastName, string email, string password);

        AuthenticationResponse Login(string email, string password);
    }
}
