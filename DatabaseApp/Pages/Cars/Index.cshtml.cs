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
    public class IndexModel : PageModel
    {
        private readonly DatabaseApp.Data.CarContext _context;

        public IndexModel(DatabaseApp.Data.CarContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Cars.ToListAsync();
        }
    }
}
