﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Licenta.Data.LicentaContext _context;

        public IndexModel(Licenta.Data.LicentaContext context)
        {
            _context = context;
        }

        public IList<CategorieVehicul> CategorieVehicul { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CategorieVehicul != null)
            {
                CategorieVehicul = await _context.CategorieVehicul.ToListAsync();
            }
        }
    }
}
