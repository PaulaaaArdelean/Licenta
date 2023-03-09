using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Licenta.Data;
using Licenta.Models;

namespace Licenta.Pages.Oferte
{
    public class DeleteModel : PageModel
    {
        private readonly Licenta.Data.LicentaContext _context;

        public DeleteModel(Licenta.Data.LicentaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Oferta Oferta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Oferta == null)
            {
                return NotFound();
            }

            var oferta = await _context.Oferta.FirstOrDefaultAsync(m => m.ID == id);

            if (oferta == null)
            {
                return NotFound();
            }
            else 
            {
                Oferta = oferta;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Oferta == null)
            {
                return NotFound();
            }
            var oferta = await _context.Oferta.FindAsync(id);

            if (oferta != null)
            {
                Oferta = oferta;
                _context.Oferta.Remove(Oferta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
