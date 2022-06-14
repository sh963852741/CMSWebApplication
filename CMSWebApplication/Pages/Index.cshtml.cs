using CMSWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMSWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CMSWebApplication.Data.CMSContext _context;

        public IndexModel(ILogger<IndexModel> logger, CMSWebApplication.Data.CMSContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Notice> Notice { get; set; } = default!;

        public void OnGet()
        {
            if (_context.Notice != null)
            {
                Notice = _context.Notice.ToList();
            }
        }
    }
}