using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CMSWebApplication.Data;
using CMSWebApplication.Models;

namespace CMSWebApplication.Pages.Notices
{
    public class CreateModel : PageModel
    {
        private readonly CMSWebApplication.Data.CMSContext _context;

        public CreateModel(CMSWebApplication.Data.CMSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Notice Notice { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Notice == null || Notice == null)
            {
                return Page();
            }

            _context.Notice.Add(Notice);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
