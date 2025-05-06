using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETWEBMVC.Models;
using ASPNETWEBMVC.ViewModels;

namespace ASPNETWEBMVC.Controllers
{
    public class ReportController : Controller
    {
        private EComerceDBEntities db = new EComerceDBEntities();
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BestItems()
        {
            var data = db.OrderDetails
                .GroupBy(od => od.ItemID)
                .Select(g => new ItemReportViewModel
                {
                     ItemID = g.Key ?? 0,
                     ItemName = db.Items.Where(i => i.ItemID == g.Key).Select(i => i.ItemName).FirstOrDefault(),
                     TotalQuantity = g.Sum(od => od.Quantity) ?? 0
                }).ToList();

            return View(data);
        }

        public ActionResult ItemsByAgent(int agentId)
        {
            var items = db.OrderDetails
                .Where(od => od.Order.AgentID == agentId)
                .GroupBy(od => od.Item)
                .Select(g => new ItemsByAgentViewModel
                {
                    ItemName = g.Key.ItemName,
                    TotalQuantity = g.Sum(od => od.Quantity) ?? 0
                })
                .ToList();

            ViewBag.AgentName = db.Agents.Find(agentId)?.AgentName;
            return View(items);
        }


        public ActionResult AgentPurchases()
        {
            var data = db.Orders
                .GroupBy(o => o.Agent)
                .Select(g => new AgentPurchaseSummaryViewModel
                {
                    AgentName = g.Key.AgentName,
                    TotalOrders = g.Count(),
                    TotalAmount = g.Sum(o => o.TotalAmount) ?? 0
                }).ToList();

            return View(data);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
