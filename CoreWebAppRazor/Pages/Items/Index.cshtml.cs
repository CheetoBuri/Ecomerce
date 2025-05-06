using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreWebAppRazor.Models;

namespace CoreWebAppRazor.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly CoreWebAppRazor.Models.EComerceDbContext _context;

        public IndexModel(CoreWebAppRazor.Models.EComerceDbContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
