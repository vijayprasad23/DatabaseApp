using System;
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
    public class DetailsModel : PageModel
    {
        private readonly DatabaseApp.Data.CarContext _context;

        public DetailsModel(DatabaseApp.Data.CarContext context)
        {
            _context = context;
        }

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
    }
}
