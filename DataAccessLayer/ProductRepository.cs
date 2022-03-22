using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Product> Get()
        {
          return _dbConnection.Query<Product>(
                    "Select ProductId,ProductName, ProductCost, ProductImage from ProductsDB.dbo.products")
                .ToList();
        }

        public Product GetBy(int id)
        {
            return  _dbConnection.Query<Product>($"Select * from ProductsDB.dbo.products Where ProductId={id}").SingleOrDefault();
        }

        public bool Insert(string productName, int productCost, string productImage)
        {
            try
            {
                _dbConnection.Query<Product>(
                    "Insert Into ProductsDB.dbo.products ProductName,ProductCost,ProductImage");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int productId, string productName, int productCost, string productImage)
        {
            try
            {
                _dbConnection.Query<Product>(
                    "update ProductsDB.dbo.products set ProductName=@productName,ProductCost=@productCost,ProductImage=@productImage");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int productId)
        {
            try
            {
                _dbConnection.Query<Product>(
                    "delete from ProductsDB.dbo.products ProductId=productId");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
