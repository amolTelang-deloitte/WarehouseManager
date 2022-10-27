using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using WarehouseManagementService.Domain.Entities;
using WarehouseManagementService.Application.Interface;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehouseManagementService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        //get all orders
        [HttpGet("orders")]
        [Authorize(Policy = "Manager")]
        public ActionResult<List<Order>> GetAllOrders()
        {
            var orders = _orderService.GetAllOrders();
            return Ok(orders);
        }

        //get status of a particular order
        [HttpGet("orders/status/{orderId:long}")]
        [Authorize(Policy = "Manager")]
        public ActionResult<string> GetOrderStatus(long orderId)
        {
            var status = _orderService.GetOrderStatus(orderId);
            return Ok(status);
        }
       
    }
}
