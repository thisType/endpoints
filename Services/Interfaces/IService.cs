using AssessmentRest.Models;

namespace AssessmentRest.Services.Interfaces
{
    public interface IService
    {

        public Task<IEnumerable<Product>> GetProducts(int skip);

        public  Task<IEnumerable<Product>> FilterProducts(string name, int price);
    }
}
