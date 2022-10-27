using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Application.Interface;
using WarehouseManagementService.Application.Repository;
using WarehouseManagementService.Domain.Entities;
using WarehouseManagementService.Infrastructure.Persistence;

namespace WarehouseManagementService.Infrastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _dbContext;

        public OrderRepository(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Order> GetAllOrders()
        {
           return _dbContext.orders.ToList();
        }

        public string GetOrderStatus(long OrderId)
        {
            return _dbContext.orders.Find(OrderId).Status;
        }
    }
}
