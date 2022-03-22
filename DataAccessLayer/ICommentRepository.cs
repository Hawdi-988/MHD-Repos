using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public interface ICommentRepository
    {
        List<Comment> Get();
        Comment GetBy(int id);
        bool Insert(int viewerId,string context,int productId);
        bool Update(int commentId, int viewerId, string context, int productId);
        bool Delete(int commentId);
    }
}
