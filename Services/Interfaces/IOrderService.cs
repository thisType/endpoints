using AssessmentRest.Models;

namespace AssessmentRest.Services.Interfaces
{
    public interface IOrderService
    {
        public Task<Order> AddOrder(Order order);
    }
}
