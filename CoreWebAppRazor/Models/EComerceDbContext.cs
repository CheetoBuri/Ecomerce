using Microsoft.EntityFrameworkCore;

namespace CoreWebAppRazor.Models
{
    public class EComerceDbContext : DbContext
    {
        public EComerceDbContext(DbContextOptions<EComerceDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Agent)
                .WithMany(a => a.Orders)
                .HasForeignKey(o => o.AgentID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Item)
                .WithMany(i => i.OrderDetails)
                .HasForeignKey(od => od.ItemID);
        }
    }
}
