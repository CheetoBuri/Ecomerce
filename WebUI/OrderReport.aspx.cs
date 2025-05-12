using System;
using System.Linq;
using System.Web.UI;
using BLL;
using DAL.Models;

namespace WebUI
{
    public partial class OrderReport : Page
    {
        private OrderService orderService = new OrderService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var orders = orderService.GetAllOrders();

                var reportData = orders.Select(o => new
                {
                    o.OrderID,
                    o.OrderDate,
                    AgentName = o.Agent.AgentName,
                    TotalAmount = o.OrderDetails.Sum(d => d.Quantity * d.UnitAmount)
                }).ToList();

                gvOrders.DataSource = reportData;
                gvOrders.DataBind();
            }
        }
    }
}
