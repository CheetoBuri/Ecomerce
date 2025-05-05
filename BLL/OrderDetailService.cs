using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class OrderDetailService
    {
        private OrderDetailRepository orderDetailRepository;

        public OrderDetailService()
        {
            orderDetailRepository = new OrderDetailRepository();
        }

        public void AddOrderDetail(OrderDetail detail)
        {
            orderDetailRepository.InsertOrderDetail(detail);
        }
    }
}

