using System.Collections.Generic;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product GetBy(int id);
        bool Insert(string productName, int productCost, string productImage);
        bool Update(int productId, string productName, int productCost, string productImage);
        bool Delete(int productId);
    }
}