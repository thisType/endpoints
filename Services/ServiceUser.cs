using AssessmentRest.Models;
using AssessmentRest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRest.Services
{
    public class ServiceUser : IServiceUser
    {


        PDbContext _dbContext;


        ServiceUser(PDbContext dbContext)
        {


            _dbContext = dbContext;
        }


        public async Task<User> AddUser(User user)
        {

            _dbContext.users.Add(user);

            await _dbContext.SaveChangesAsync();

            return user;



        }

        public  async Task<List<Order>> GetOrders(Guid userId)
        {

            var user = await _dbContext.users.Include(c => c.Orders).FirstOrDefaultAsync(c => c.UserId == userId);

            return (List<Order>)user.Orders;
            



        }


    }
}
