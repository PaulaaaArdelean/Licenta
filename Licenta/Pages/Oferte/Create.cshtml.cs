using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Licenta.Data;
using Licenta.Models;

namespace Licenta.Pages.Oferte
{
    public class CreateModel : PageModel
    {
        private readonly Licenta.Data.LicentaContext _context;

        public CreateModel(Licenta.Data.LicentaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ClientID"] = new SelectList(_context.Client, "ID", "NumeIntreg");
        ViewData["VehiculID"] = new SelectList(_context.Vehicul, "ID", "NrInmatriculare");
            return Page();
        }

        [BindProperty]
        public Oferta Oferta { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Oferta.Add(Oferta);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
