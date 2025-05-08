using Microsoft.EntityFrameworkCore;
using CoreWebAppMVC.Models;

namespace CoreWebAppMVC.Models
{
    public class ApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
