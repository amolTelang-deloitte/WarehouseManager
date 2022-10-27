using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Applcation.Common.Interfaces.Authentication
{
    public interface IJwtGenerator
    {
        string GenerateToken(Guid userId, string firstName, string lastName);
    }
}
