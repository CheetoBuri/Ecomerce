using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using CoreWebAppRazor.Models;
using CoreWebAppRazor.Pages.Orders;
using System.Linq;


namespace CoreWebAppRazorTest
{
    public class IndexPageTests
    {
        private EComerceDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<EComerceDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;
            var context = new EComerceDbContext(options);

            // Seed data
            context.Agents.Add(new Agent { AgentID = 1, AgentName = "Test Agent" });
            context.Items.Add(new Item { ItemID = 1, ItemName = "Test Item", Price = 10 });
            context.Orders.Add(new Order
            {
                OrderID = 1,
                AgentID = 1,
                OrderDate = System.DateTime.Now,
                TotalAmount = 100,
                OrderDetails = new[]
                {
                    new OrderDetail { ID = 1, ItemID = 1, Quantity = 5, UnitAmount = 10 }
                }
            });
            context.SaveChanges();
            return context;
        }

        [Fact]
        public async Task OnGetAsync_ReturnsOrders()
        {
            // Arrange
            var context = GetDbContext();
            var pageModel = new IndexModel(context);

            // Act
            await pageModel.OnGetAsync();

            // Assert
            Assert.Single(pageModel.Order);
            Assert.Equal(1, pageModel.Order.First().OrderID);
        }

        [Fact]
        public async Task OnGetAsync_BestItemsFilter_Works()
        {
            var context = GetDbContext();
            var pageModel = new IndexModel(context)
            {
                FilterType = "bestItems"
            };

            await pageModel.OnGetAsync();

            Assert.Single(pageModel.Order);
            Assert.Equal(1, pageModel.Order.First().OrderID);
        }
    }
}