using AssessmentRest.Dto;
using AssessmentRest.Models;
using AssessmentRest.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssessmentRest.Services
{
    public class Service : IService



    {

        PDbContext _db;


        public Service(PDbContext db)
        {

            _db = db;
        }


        public async Task<IEnumerable<Product>> GetProducts(int skip) { 

            var products =  await _db.products.Skip(skip).Take(5).ToListAsync();

             return products;


        }

        public  async Task<IEnumerable<Product>> FilterProducts(string name, int price)
        {
            var productsWithNamePrice = await _db.products.Where(p => p.ProductName.Contains("laptop") || p.ProductPrice == price).ToListAsync();

            return productsWithNamePrice;


        }
    }
}
