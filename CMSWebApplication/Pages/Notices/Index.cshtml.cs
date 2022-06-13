using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CMSWebApplication.Data;
using CMSWebApplication.Models;

namespace CMSWebApplication.Pages.Notices
{
    public class IndexModel : PageModel
    {
        private readonly CMSWebApplication.Data.CMSContext _context;

        public IndexModel(CMSWebApplication.Data.CMSContext context)
        {
            _context = context;
        }

        public IList<Notice> Notice { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Notice != null)
            {
                Notice = await _context.Notice.ToListAsync();
            }
        }
    }
}
