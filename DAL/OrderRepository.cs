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
    public class OrderRepository
    {
        public void InsertOrder(Order order)
        {
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("INSERT INTO [Order] (OrderID, OrderDate, AgentID, TotalAmount) VALUES (@OrderID, @OrderDate, @AgentID, @TotalAmount)", conn);
                cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@AgentID", order.AgentID);
                cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
