using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWEBMVC.ViewModels
{
    public class ItemReportViewModel
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int TotalQuantity { get; set; }
    }
}