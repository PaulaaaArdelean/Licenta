using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Licenta.Data;
using Licenta.Models;

namespace Licenta.Pages.CategoriiVehicule
{
    public class DetailsModel : PageModel
    {
        private readonly Licenta.Data.LicentaContext _context;

        public DetailsModel(Licenta.Data.LicentaContext context)
        {
            _context = context;
        }

      public CategorieVehicul CategorieVehicul { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CategorieVehicul == null)
            {
                return NotFound();
            }

            var categorievehicul = await _context.CategorieVehicul.FirstOrDefaultAsync(m => m.ID == id);
            if (categorievehicul == null)
            {
                return NotFound();
            }
            else 
            {
                CategorieVehicul = categorievehicul;
            }
            return Page();
        }
    }
}
