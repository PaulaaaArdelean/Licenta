using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Licenta.Models;

namespace Licenta.Data
{
    public class LicentaContext : DbContext
    {
        public LicentaContext (DbContextOptions<LicentaContext> options)
            : base(options)
        {
        }

        public DbSet<Licenta.Models.Vehicul> Vehicul { get; set; } = default!;

        public DbSet<Licenta.Models.TipCombustibil> TipCombustibil { get; set; }

        public DbSet<Licenta.Models.CategorieVehicul> CategorieVehicul { get; set; }

        public DbSet<Licenta.Models.Client> Client { get; set; }

        public DbSet<Licenta.Models.TipSocietate> TipSocietate { get; set; }
    }
}
