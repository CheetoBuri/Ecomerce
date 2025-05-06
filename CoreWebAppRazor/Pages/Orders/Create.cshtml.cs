using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreWebAppRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreWebAppRazor.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly EComerceDbContext _context;

        public CreateModel(EComerceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }
        public IList<Item> Items { get; set; }
        public IList<Agent> Agents { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // Load all available items and agents for selection
            Items = await _context.Items.ToListAsync();
            Agents = await _context.Agents.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // If the model state is invalid, return to the page with validation errors
                return Page();
            }

            // Set the OrderDate to the current date
            Order.OrderDate = DateTime.Now;
            Order.TotalAmount = 0;

            // Calculate the total amount and add items to the OrderDetails collection
            foreach (var item in Items)
            {
                // Get the quantity for the current item from the form
                var quantity = Request.Form[$"OrderDetails[{item.ItemID}].Quantity"];

                if (int.TryParse(quantity, out int qty) && qty > 0)
                {
                    // Create the OrderDetail for the item
                    OrderDetail orderDetail = new OrderDetail
                    {
                        ItemID = item.ItemID,
                        Quantity = qty,
                        UnitAmount = item.Price
                    };

                    // Add the OrderDetail to the order
                    Order.OrderDetails.Add(orderDetail);

                    // Update the total amount for the order
                    Order.TotalAmount += orderDetail.Quantity * orderDetail.UnitAmount;
                }
            }

            // Save the new order to the database
            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            // Redirect to the Order index page
            return RedirectToPage("./Index");
        }
    }
}
