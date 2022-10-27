using IdentityServer.Applcation.Common.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime utcNow => DateTime.UtcNow;
    }
}
