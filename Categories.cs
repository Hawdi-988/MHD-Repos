using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_test_001130
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CaregoryName { get; set; }
        public PrductsCategories PrductsCategory { get; set; }
    }
}
