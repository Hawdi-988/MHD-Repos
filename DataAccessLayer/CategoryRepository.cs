using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly IDbConnection _dbConnection;

        public CategoryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public List<Category> Get()
        {
            return _dbConnection.Query<Category>("select CategoryId,CategoryName from ProductsDB.dbo.Categories")
                .ToList();
        }

        public Category GetBy(int id)
        {
            return _dbConnection.Query<Category>($"select * from ProductsDB.dbo.Categories where CategoryId={id}")
                .SingleOrDefault();
        }

        public bool Insert(string categoryName)
        {
            try
            {
                _dbConnection.Query<Category>("insert into ProductsDB.dbo.Categories CategoryName");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int categoryId, string categoryName)
        {
            try
            {
                _dbConnection.Query<Category>("update ProductsDB.dbo.Categories set CategoryName=@categoryName");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int categoryId)
        {
            try
            {
                _dbConnection.Query<Category>(
                    "delete from ProductsDB.dbo.Categories where CategoryId=categoryId");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
