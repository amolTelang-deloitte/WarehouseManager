using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementService.Domain.Entities;

namespace WarehouseManagementService.Application.Interface
{
    public interface IOrderService
    {
        //get all orders
        List<Order> GetAllOrders();

        //get order status of a particular order
        string GetOrderStatus(long OrderId);
    }
}
