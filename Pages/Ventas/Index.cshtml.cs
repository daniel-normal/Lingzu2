using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lingzu.Data;
using Lingzu.Models;

namespace Lingzu.Pages.Ventas
{
    public class IndexModel : PageModel
    {
        private readonly Lingzu.Data.LingzuContext _context;

        public IndexModel(Lingzu.Data.LingzuContext context)
        {
            _context = context;
        }

        public IList<Venta> Venta { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Venta != null)
            {
                Venta = await _context.Venta.ToListAsync();
            }
        }
    }
}
