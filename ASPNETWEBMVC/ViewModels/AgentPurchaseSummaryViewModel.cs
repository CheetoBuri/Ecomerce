using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWEBMVC.ViewModels
{
    public class AgentPurchaseSummaryViewModel
    {
        public string AgentName { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalAmount { get; set; }
    }
}