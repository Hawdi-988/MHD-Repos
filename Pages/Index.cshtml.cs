using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication_test_001130.DataAccessLayer;

namespace WebApplication_test_001130.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductRepository _productRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IViewerRepository _viewerRepository;

        public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }
        public IndexModel(ILogger<IndexModel> logger, ICommentRepository commentRepository)
        {
            _logger = logger;
            _commentRepository = commentRepository;
        }

        public void OnGet()
        {
            var products = _productRepository.Get();        
            
        }
    }
}
