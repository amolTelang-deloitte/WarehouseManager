using Arch.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Application.Interface;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.Infrastructure.Persistence
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {

        }
        public DbSet<Order> orders { get; set; }
    }
}
