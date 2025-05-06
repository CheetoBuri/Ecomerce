using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreWebAppRazor.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitAmount { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }


    }
}
