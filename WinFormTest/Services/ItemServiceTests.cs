using System;
using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WinFormTest.Services
{
    [TestClass]
    public class ItemServicesTests
    {
        private ItemService itemService;

        [TestInitialize]
        public void Setup()
        {
            itemService = new ItemService();
        }

        [TestMethod]
        public void GetAllItems_ShouldReturnList()
        {
            var items = itemService.GetAllItems();
            Assert.IsNotNull(items);
            Assert.IsTrue(items.Count >= 0);
        }

        [TestMethod]
        public void GetTopSellingItems_ShouldReturnList()
        {
            var topItems = itemService.GetTopSellingItems();
            Assert.IsNotNull(topItems);
        }
    }
}
