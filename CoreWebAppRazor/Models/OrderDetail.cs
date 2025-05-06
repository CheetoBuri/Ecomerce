using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreWebAppRazor.Models
{
    public class OrderDetail
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        [Required]
        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public Item Item { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitAmount { get; set; }
    }
}
