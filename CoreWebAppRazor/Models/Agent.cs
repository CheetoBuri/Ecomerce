using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebAppRazor.Models
{
    [Table("Agent")]
    public class Agent
    {
        [Key]
        public int AgentID { get; set; }

        [Required]
        [StringLength(100)]
        public string AgentName { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
