using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class OrderService
    {
        private OrderRepository orderRepository;
        private readonly OrderRepository _orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public void PlaceOrder(Order order)
        {
            // Example: add total calculation or other logic here if needed
            order.OrderDate = DateTime.Now;
            orderRepository.InsertOrder(order);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            return _orderRepository.GetOrderDetails(orderId);
        }
    }
}
