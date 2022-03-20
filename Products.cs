using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_test_001130
{
    public class Products
    {
        [Key] public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductCost { get; set; }
        public string ProductImage { get; set; }
        public PrductsCategories PrductsCategory { get; set; }
        public Comments Comment { get; set; }
    }
}
