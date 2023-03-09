using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Licenta.Data;
using Licenta.Models;

namespace Licenta.Pages.Vehicule
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
            ViewData["TipCombustibilID"] = new SelectList(_context.Set<TipCombustibil>(), "ID", "TipulCombustibil");
            ViewData["CategorieVehiculID"] = new SelectList(_context.Set<CategorieVehicul>(), "ID", "CategoriaVehicul");
            return Page();
        }

        [BindProperty]
        public Vehicul Vehicul { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                
                return Page();
            }

            _context.Vehicul.Add(Vehicul);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
