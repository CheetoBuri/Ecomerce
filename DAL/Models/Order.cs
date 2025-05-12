using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Order")]
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int AgentID { get; set; }
        public decimal TotalAmount { get; set; }
        public virtual Agent Agent { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

