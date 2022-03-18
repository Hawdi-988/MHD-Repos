using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_test_001130
{
    public class Comments
    {
        [Key] public int CommentID { get; set; }
        public int ViewerID { get; set; }
        public string Context { get; set; }
        public int ProductID { get; set; }
    }
}
