using AssessmentRest.Dto;
using AssessmentRest.Models;

namespace AssessmentRest
{
    public class DtoUtility
    {

        public  Order FromDto(OrderDto dto)
        {
            Order order = new Order();

            order.OrderId = dto.OrderId;
            order.ProductId = dto.ProductId;
            order.UserId = dto.UserId;

            return order;   


        }
    }
}
