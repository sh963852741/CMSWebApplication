using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CMSWebApplication.Data;
using CMSWebApplication.Models;

namespace CMSWebApplication.Pages.Notices
{
    public class EditModel : PageModel
    {
        private readonly CMSWebApplication.Data.CMSContext _context;

        public EditModel(CMSWebApplication.Data.CMSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Notice Notice { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Notice == null)
            {
                return NotFound();
            }

            var notice =  await _context.Notice.FirstOrDefaultAsync(m => m.ID == id);
            if (notice == null)
            {
                return NotFound();
            }
            Notice = notice;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Notice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoticeExists(Notice.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NoticeExists(int id)
        {
          return (_context.Notice?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
