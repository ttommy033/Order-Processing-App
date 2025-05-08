using ControllerProblem.DTO;

namespace ControllerProblem.Interface
{
    public interface IOrderService
    {
        void CreateOrder(CreateOrderDTO order);
    }
}