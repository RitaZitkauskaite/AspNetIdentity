using AspNetIdentity.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetIdentity.Pages

{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndexModel(IHttpContextAccessor httpContextAccessor, ILogger<IndexModel> logger)
        {
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }

        public List<Note> Notes { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

       
    }
}