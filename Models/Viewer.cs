using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_test_001130.Models
{
    public class Viewer
    {
        [Key] public int ViewerId { get; set; }
        public string ViewerName { get; set; }
        public string ViewerEmail { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
