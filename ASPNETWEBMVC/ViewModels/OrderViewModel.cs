using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPNETWEBMVC.Models;

namespace ASPNETWEBMVC.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public OrderViewModel()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}