namespace CoreWebAppMVC.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
