using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public class ProductCategoryRepository: IProductCategoryRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductCategoryRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<ProductCategory> Get()
        {

            return _dbConnection
                .Query<ProductCategory>("select ProductId, CategoryId from ProductsDB.dbo.ProductsCategories").ToList();
        }

        public ProductCategory GetBy(int id)
        {
            return _dbConnection.Query<ProductCategory>($"select * from ProductsDB.dbo.ProductsCategories where ProductId+CategoryId={id}")
                .SingleOrDefault();
        }

        public bool Insert(int productId, int categoryId)
        {
            try
            {
                _dbConnection.Query<ProductCategory>("insert into ProductsDB.dbo.ProductsCategories ProductId,CategoryId");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int productId, int categoryId)
        {
            try
            {
                _dbConnection.Query<ProductCategory>(
                    "update ProductsDB.dbo.ProductsCategories set ProductId=@productId,CategoryId=@categoryId");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int productId, int categoryId)
        {
            try
            {
                _dbConnection.Query<ProductCategory>(
                    "delete from ProductsDB.dbo.ProductCategories ProductId=productId and CategoryId=categoryId");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
