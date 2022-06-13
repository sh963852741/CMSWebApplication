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
    public class DetailsModel : PageModel
    {
        private readonly CMSWebApplication.Data.CMSContext _context;

        public DetailsModel(CMSWebApplication.Data.CMSContext context)
        {
            _context = context;
        }

      public Notice Notice { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Notice == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice.FirstOrDefaultAsync(m => m.ID == id);
            if (notice == null)
            {
                return NotFound();
            }
            else 
            {
                Notice = notice;
            }
            return Page();
        }
    }
}
