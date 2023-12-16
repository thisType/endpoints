using AssessmentRest.Models;

namespace AssessmentRest.Services.Interfaces
{
    public interface IServiceUser
    {

        public Task<User> AddUser(User user);


        public Task<List<Order>> GetOrders(Guid userId);
        
        }
}
