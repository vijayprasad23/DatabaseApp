﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DatabaseApp.Data;
using DatabaseApp.Models;

namespace DatabaseApp.Pages.Manufacturers
{
    public class DeleteModel : PageModel
    {
        private readonly DatabaseApp.Data.CarContext _context;

        public DeleteModel(DatabaseApp.Data.CarContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manufacturer Manufacturer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacturer = await _context.Manufacturers.FirstOrDefaultAsync(m => m.ManufacturerID == id);

            if (Manufacturer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacturer = await _context.Manufacturers.FindAsync(id);

            if (Manufacturer != null)
            {
                _context.Manufacturers.Remove(Manufacturer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
