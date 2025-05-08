using ControllerProblem.DTO;
using ControllerProblem.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ControllerProblem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        //now taking in a createOrderDTO
        public IActionResult CreateOrder([FromBody] CreateOrderDTO order)
        {
            if (order == null || string.IsNullOrWhiteSpace(order.ProductName))
                return BadRequest("Invalid order.");

            _orderService.CreateOrder(order);
            return Ok("Order created");
        }
    }
}
//refactor this to a service implementation an interface, a dto