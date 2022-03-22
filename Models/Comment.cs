using System.ComponentModel.DataAnnotations;

namespace WebApplication_test_001130.Models
{
    public class Comment
    {
        [Key] public int CommentId { get; set; }
        public int ViewerId { get; set; }
        public string Context { get; set; }
        public int ProductId { get; set; }
    }
}
