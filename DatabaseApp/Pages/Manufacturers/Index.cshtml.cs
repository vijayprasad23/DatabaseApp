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
    public class IndexModel : PageModel
    {
        private readonly DatabaseApp.Data.CarContext _context;

        public IndexModel(DatabaseApp.Data.CarContext context)
        {
            _context = context;
        }

        public IList<Manufacturer> Manufacturer { get;set; }

        public async Task OnGetAsync()
        {
            Manufacturer = await _context.Manufacturers.ToListAsync();
        }
    }
}
