using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Models;

namespace DAL
{
    public class OrderDetailRepository
    {
        public void InsertOrderDetail(OrderDetail detail)
        {
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("INSERT INTO OrderDetail (ID, OrderID, ItemID, Quantity, UnitAmount) VALUES (@ID, @OrderID, @ItemID, @Quantity, @UnitAmount)", conn);
                cmd.Parameters.AddWithValue("@ID", detail.ID);
                cmd.Parameters.AddWithValue("@OrderID", detail.OrderID);
                cmd.Parameters.AddWithValue("@ItemID", detail.ItemID);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.Parameters.AddWithValue("@UnitAmount", detail.UnitAmount);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
