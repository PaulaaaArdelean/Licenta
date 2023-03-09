using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Licenta.Data;
using Licenta.Models;

namespace Licenta.Pages.TipuriSocietati
{
    public class DetailsModel : PageModel
    {
        private readonly Licenta.Data.LicentaContext _context;

        public DetailsModel(Licenta.Data.LicentaContext context)
        {
            _context = context;
        }

      public TipSocietate TipSocietate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipSocietate == null)
            {
                return NotFound();
            }

            var tipsocietate = await _context.TipSocietate.FirstOrDefaultAsync(m => m.ID == id);
            if (tipsocietate == null)
            {
                return NotFound();
            }
            else 
            {
                TipSocietate = tipsocietate;
            }
            return Page();
        }
    }
}
