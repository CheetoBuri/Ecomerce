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

        public OrderRepository()
        {
            _context = new EComerceDBContext();
        }

        public void InsertOrder(Order order)
        {
            _context.Orders.Add(order); // Use EF to add the order
            _context.SaveChanges(); // Save changes to the DB
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include("Agent") // Including related Agent data
                .Include("OrderDetails.Item") // Including related Item data in OrderDetails
                .ToList(); // Return list of orders
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return _context.OrderDetails
                .Where(od => od.OrderID == orderId)
                .ToList(); // Get order details by orderId
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order); // Add new order
            _context.SaveChanges(); // Save changes
        }
    }
}
