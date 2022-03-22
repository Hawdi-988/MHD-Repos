using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IDbConnection _dbConnection;

        public CommentRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public List<Comment> Get()
        {
            return _dbConnection
                .Query<Comment>("select CommentId,ViewerId,Context,ProductId from ProductsDB.dbo.Comments").ToList();
        }

        public Comment GetBy(int id)
        {
            return _dbConnection.Query<Comment>($"select * from ProductsDB.dbo.Comments where CommentId={id}")
                .SingleOrDefault();
        }

        public bool Insert(int viewerId, string context, int productId)
        {
            try
            {
                _dbConnection.Query<Comment>("insert into ProductsDB.dbo.Comments ViewerId,Context,ProductId");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int commentId, int viewerId, string context, int productId)
        {
            try
            {
                _dbConnection.Query<Comment>(
                    "update ProductsDB.dbo.Comments set ViewerId=@vieweId,Context=@context,ProductId=@productId");
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool Delete(int commentId)
        {
            try
            {
                _dbConnection.Query<Comment>(
                    "delete from ProductsDB.dbo.Comments CommentId=commentId");
                return true;
            }
            catch
            {
                return false;
            }
        }

       
    }
}
