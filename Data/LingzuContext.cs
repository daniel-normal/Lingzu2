using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lingzu.Models;

namespace Lingzu.Data
{
    public class LingzuContext : DbContext
    {
        public LingzuContext (DbContextOptions<LingzuContext> options)
            : base(options)
        {
        }

        public DbSet<Lingzu.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<Lingzu.Models.Producto>? Producto { get; set; }

        public DbSet<Lingzu.Models.Venta>? Venta { get; set; }
    }
}
