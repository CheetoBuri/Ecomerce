using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DAL.Models;

namespace DAL
{
    public class ItemRepository
    {
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
    }
}
