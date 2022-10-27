using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Application.Interface;
using WarehouseManagementService.Application.Repository;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.Application.Services
{
    public class OrderServices : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderServices(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders();
            return orders;
        }

        public string GetOrderStatus(long OrderId)
        {
            var status=_orderRepository.GetOrderStatus(OrderId);
            return status;
        }
    }
}
