using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("Item")]
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

