using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebAppRazor.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
