using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public interface ICategoryRepository
    {
        List<Category> Get();
        Category GetBy(int id);
        bool Insert(string categoryName);
        bool Update(int categoryId, string categoryName);
        bool Delete(int categoryId);
    }
}
