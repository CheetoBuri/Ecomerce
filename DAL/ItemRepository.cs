using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL.Models;
using DAL.DTOs;

namespace DAL
{
    public class ItemRepository
    {
        private readonly EComerceDBContext _context;
        public List<Item> GetAllItems()
        {
            var items = new List<Item>();
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("SELECT * FROM Item", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new Item
                    {
                        ItemID = (int)reader["ItemID"],
                        ItemName = reader["ItemName"].ToString(),
                        Size = reader["Size"].ToString(),
                        Price = (decimal)reader["Price"]
                    });
                }
            }
            return items;
        }

        public void InsertItem(Item item)
        {
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("INSERT INTO Item (ItemID, ItemName, Size, Price) VALUES (@ItemID, @ItemName, @Size, @Price)", conn);
                cmd.Parameters.AddWithValue("@ItemID", item.ItemID);
                cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                cmd.Parameters.AddWithValue("@Size", item.Size);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public ItemRepository()
        {
            _context = new EComerceDBContext();
        }

        public List<ItemReportDto> GetTopSellingItems()
        {
            var result = _context.OrderDetails
                .GroupBy(od => od.ItemID)
                .Select(g => new ItemReportDto
                {
                    ItemID = g.Key,
                    ItemName = g.FirstOrDefault().Item.ItemName,
                    TotalQuantity = g.Sum(x => x.Quantity)
                })
                .OrderByDescending(r => r.TotalQuantity)
                .Take(10)
                .ToList();

            return result;
        }

        public List<ItemReportDto> GetItemsByAgent(int agentId)
        {
            var result = _context.OrderDetails
                .Where(od => od.Order.AgentID == agentId)
                .GroupBy(od => od.ItemID)
                .Select(g => new ItemReportDto
                {
                    ItemID = g.Key,
                    ItemName = g.FirstOrDefault().Item.ItemName,
                    TotalQuantity = g.Sum(x => x.Quantity)
                })
                .ToList();

            return result;
        }

        public List<PurchaseSummaryDto> GetAgentPurchaseSummary(int agentId)
        {
            var result = _context.Orders
                .Where(o => o.AgentID == agentId)
                .Select(o => new PurchaseSummaryDto
                {
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.TotalAmount
                })
                .ToList();

            return result;
        }
    }
}
