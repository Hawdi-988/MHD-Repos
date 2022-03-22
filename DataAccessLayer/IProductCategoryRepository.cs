using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public interface IProductCategoryRepository
    {
        List<ProductCategory> Get();
        ProductCategory GetBy(int id);
        bool Insert(int productId, int categoryId);
        bool Update(int productId, int categoryId);
        bool Delete(int productId, int categoryId);
    }
}
