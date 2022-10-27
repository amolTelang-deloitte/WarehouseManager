using Arch.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.Infrastructure.Persistence
{
    public  class PalletDbContext:DbContext
    {
        public PalletDbContext(DbContextOptions<PalletDbContext> options) : base(options)
        {

        }
        public DbSet<Pallet> Pallets { get; set; }
    }
}
