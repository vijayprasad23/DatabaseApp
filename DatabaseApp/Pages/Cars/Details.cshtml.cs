using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DatabaseApp.Data;
using DatabaseApp.Models;

namespace DatabaseApp.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly DatabaseApp.Data.CarContext _context;

        public DetailsModel(DatabaseApp.Data.CarContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Cars.FirstOrDefaultAsync(m => m.CarID == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
