﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPCoreWebAppMVC.Models;

namespace ASPCoreWebAppMVC.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly ECommerceDbContext _context;

        public OrderDetailsController(ECommerceDbContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index()
        {
            var eCommerceDbContext = _context.OrderDetails.Include(o => o.Item).Include(o => o.Order);
            return View(await eCommerceDbContext.ToListAsync());
        }

        // GET: OrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails
                .Include(o => o.Item)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public IActionResult Create()
        {
            ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "ItemID");
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID");
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,OrderID,ItemID,Quantity,UnitAmount")] OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "ItemID", orderDetail.ItemID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", orderDetail.OrderID);
            return View(orderDetail);
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail == null)
            {
                return NotFound();
            }
            ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "ItemID", orderDetail.ItemID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", orderDetail.OrderID);
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,OrderID,ItemID,Quantity,UnitAmount")] OrderDetail orderDetail)
        {
            if (id != orderDetail.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderDetailExists(orderDetail.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemID"] = new SelectList(_context.Items, "ItemID", "ItemID", orderDetail.ItemID);
            ViewData["OrderID"] = new SelectList(_context.Orders, "OrderID", "OrderID", orderDetail.OrderID);
            return View(orderDetail);
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.OrderDetails
                .Include(o => o.Item)
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderDetail = await _context.OrderDetails.FindAsync(id);
            if (orderDetail != null)
            {
                _context.OrderDetails.Remove(orderDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderDetailExists(int id)
        {
            return _context.OrderDetails.Any(e => e.ID == id);
        }
    }
}
