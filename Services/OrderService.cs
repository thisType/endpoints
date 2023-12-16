using AssessmentRest.Models;
using AssessmentRest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRest.Services
{
    public class OrderService : IOrderService
    {

        PDbContext _db;

        OrderService( PDbContext db)
        {
            _db = db;
        }   


        public async Task<Order> AddOrder(Order order)
        {
            await _db.orders.AddAsync(order);


            _db.SaveChanges();

            return order;


        }
    }
}
