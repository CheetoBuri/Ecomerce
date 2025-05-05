using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Models;

namespace DAL
{
    public class OrderRepository
    {
        private readonly EComerceDBContext _context;
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
        public OrderRepository()
        {
            _context = new EComerceDBContext();
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return _context.OrderDetails
                .Where(od => od.OrderID == orderId)
                .ToList();
        }
    }
}
