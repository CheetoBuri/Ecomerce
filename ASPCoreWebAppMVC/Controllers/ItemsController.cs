using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPCoreWebAppMVC.Models;

namespace ASPCoreWebAppMVC.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ECommerceDbContext _context;

        public ItemsController(ECommerceDbContext context)
        {
            _context = context;
        }

        // GET: Items
        public IActionResult Index(int? agentId, bool showBestItems = false)
        {
            var items = _context.Items.AsQueryable();

            if (showBestItems)
            {
                items = items.OrderByDescending(i =>
                    _context.OrderDetails.Where(od => od.ItemID == i.ItemID).Sum(od => (int?)od.Quantity) ?? 0);
            }
            else if (agentId != null)
            {
                var itemIds = _context.Orders
                    .Where(o => o.AgentID == agentId)
                    .SelectMany(o => _context.OrderDetails.Where(od => od.OrderID == o.OrderID).Select(od => od.ItemID))
                    .Distinct();

                items = items.Where(i => itemIds.Contains(i.ItemID));
            }

            var model = new ItemFilter
            {
                Items = items.ToList(),
                AgentID = agentId,
                ShowBestItems = showBestItems,
                Agents = _context.Agents.ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Purchase(int itemId, int agentId, int quantity)
        {
            var order = new Order
            {
                AgentID = agentId,
                OrderDate = DateTime.Now
            };

            _context.Orders.Add(order);
            _context.SaveChanges();

            var orderDetail = new OrderDetail
            {
                OrderID = order.OrderID,
                ItemID = itemId,
                Quantity = quantity,
                UnitAmount = _context.Items.Find(itemId).Price
            };

            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();

            TempData["IsLoggedIn"] = true;
            return RedirectToAction("Index");
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var item = await _context.Items.FirstOrDefaultAsync(m => m.ItemID == id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemID,ItemName,Size,Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var item = await _context.Items.FindAsync(id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        // POST: Items/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemID,ItemName,Size,Price")] Item item)
        {
            if (id != item.ItemID)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemID))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var item = await _context.Items.FirstOrDefaultAsync(m => m.ItemID == id);
            if (item == null)
                return NotFound();

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item != null)
                _context.Items.Remove(item);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.ItemID == id);
        }
    }
}
