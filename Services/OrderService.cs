using ControllerProblem.Context;
using ControllerProblem.DTO;
using ControllerProblem.Interface;
using ControllerProblem.Models;
using System.Runtime.CompilerServices;


namespace ControllerProblem.Services
{
    public class OrderService : IOrderService
    {
        // This is the constructor for the OrderService class
        //Goes above orderService
        private readonly AppDbContext _dbContext;
        Guid Id = Guid.NewGuid(); // This is a unique identifier for the order
        public OrderService(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;

        }
        public void CreateOrder(CreateOrderDTO order)
        {
            // This method creates an order
            // It takes a CreateOrderDTO object as a parameter
            // It adds the order to the database and saves changes
            var newOrder = new Order
            {
                Id = Id,
                ProductName = order.ProductName,
            };
            _dbContext.Orders.Add(newOrder);
            _dbContext.SaveChanges();
        }
    }
}