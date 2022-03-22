using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public class ViewerRepository: IViewerRepository
    {
        private readonly IDbConnection _dbConnection;
        public ViewerRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public List<Viewer> Get()
        {
            return _dbConnection
                .Query<Viewer>("select ViewerId,ViewerName,ViewerEmail from ProductsDB.dbo.Viewers").ToList();
        }

        public Viewer GetBy(int id)
        {
            return _dbConnection.Query<Viewer>($"select * from ProductsDB.dbo.Viewers where ViewerId={id}")
                .SingleOrDefault();
        }

        public bool Insert(string viewerName, string viewerEmail)
        {
            try
            {
                _dbConnection.Query<Viewer>("insert into ProductsDB.dbo.Viewers ViewerName, ViewerEmail");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(string viewerName, string viewerEmail)
        {
            try
            {
                _dbConnection.Query<Viewer>(
                    "update ProductsDB.dbo.Viewers set ViewerName=@viewerName , ViewerEmail=@viewerEmail");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int viewerId)
        {
            try
            {
                _dbConnection.Query<Viewer>(
                    "delete from ProductsDB.dbo.Viewers ViewerId=viewer");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
