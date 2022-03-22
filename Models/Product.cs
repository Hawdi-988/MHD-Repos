using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_test_001130.Models
{
    public class Product
    {
        [Key] public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public string ProductImage { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
