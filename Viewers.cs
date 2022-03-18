using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_test_001130
{
    public class Viewers
    {
        [Key] public int ViewerID { get; set; }
        public string ViewerName { get; set; }
        public string ViewerEmail { get; set; }
    }
}
