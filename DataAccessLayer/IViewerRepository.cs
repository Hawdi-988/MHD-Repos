using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_test_001130.Models;

namespace WebApplication_test_001130.DataAccessLayer
{
    public interface IViewerRepository
    {
        List<Viewer> Get();
        Viewer GetBy(int id);
        bool Insert(string viewerName, string viewerEmail);
        bool Update(string viewerName, string viewerEmail);
        bool Delete(int viewerId);
    }
}
