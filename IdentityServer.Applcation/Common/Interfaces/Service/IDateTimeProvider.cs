using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Applcation.Common.Interfaces.Service
{
    public interface IDateTimeProvider
    {
        DateTime utcNow { get; }
    }
}
