using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Licenta.Data;
using Licenta.Models;

namespace Licenta.Pages.Vehicule
{
    public class DeleteModel : PageModel
    {
        private readonly Licenta.Data.LicentaContext _context;

        public DeleteModel(Licenta.Data.LicentaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vehicul Vehicul { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vehicul == null)
            {
                return NotFound();
            }

            var vehicul = await _context.Vehicul.FirstOrDefaultAsync(m => m.ID == id);

            if (vehicul == null)
            {
                return NotFound();
            }
            else 
            {
                Vehicul = vehicul;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vehicul == null)
            {
                return NotFound();
            }
            var vehicul = await _context.Vehicul.FindAsync(id);

            if (vehicul != null)
            {
                Vehicul = vehicul;
                _context.Vehicul.Remove(Vehicul);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
