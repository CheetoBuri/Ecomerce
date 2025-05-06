using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreWebAppRazor.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int AgentID { get; set; }

        [ForeignKey("AgentID")]
        public Agent Agent { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
