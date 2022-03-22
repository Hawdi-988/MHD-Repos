using System.ComponentModel.DataAnnotations;

namespace WebApplication_test_001130.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
