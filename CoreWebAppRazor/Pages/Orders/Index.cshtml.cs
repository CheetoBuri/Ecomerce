using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreWebAppRazor.Models;

namespace CoreWebAppRazor.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly CoreWebAppRazor.Models.EComerceDbContext _context;

        public IndexModel(CoreWebAppRazor.Models.EComerceDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get; set; } = default!;
        public IList<Item> Items { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? FilterType { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? CustomerId { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<Order> query = _context.Orders
                .Include(o => o.Agent)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Item);

            // Apply filter if the FilterType is set
            if (!string.IsNullOrEmpty(FilterType))
            {
                switch (FilterType)
                {
                    case "bestItems":
                        // Get the most purchased items (best items)
                        var bestItems = await _context.OrderDetails
                            .GroupBy(od => od.ItemID)
                            .OrderByDescending(g => g.Sum(od => od.Quantity))
                            .Select(g => g.Key)
                            .ToListAsync();

                        Order = await query
                            .Where(o => o.OrderDetails.Any(od => bestItems.Contains(od.ItemID)))
                            .ToListAsync();
                        break;

                    case "itemsPurchasedByCustomer":
                        // Get items purchased by a specific customer (agent)
                        if (CustomerId.HasValue)
                        {
                            Order = await query
                                .Where(o => o.Agent.AgentID == CustomerId.Value)
                                .ToListAsync();
                        }
                        break;

                    case "customerPurchasesItems":
                        // Get orders placed by a specific customer (agent)
                        if (CustomerId.HasValue)
                        {
                            Order = await query
                                .Where(o => o.Agent.AgentID == CustomerId.Value)
                                .ToListAsync();
                        }
                        break;

                    default:
                        Order = await query.ToListAsync();
                        break;
                }
            }
            else
            {
                Order = await query.ToListAsync();
            }
        }
    }
}
