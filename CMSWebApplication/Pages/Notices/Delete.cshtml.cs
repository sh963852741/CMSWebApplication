﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly CMSWebApplication.Data.CMSContext _context;

        public DeleteModel(CMSWebApplication.Data.CMSContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Notice == null)
            {
                return NotFound();
            }
            var notice = await _context.Notice.FindAsync(id);

            if (notice != null)
            {
                Notice = notice;
                _context.Notice.Remove(Notice);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
