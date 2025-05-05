using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTOs
{
    public class ItemReportDto
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int TotalQuantity { get; set; }
    }
}
