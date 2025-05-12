using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using BLL;
using DAL.Models;

namespace WebUI
{
    public partial class CreateOrder : System.Web.UI.Page
    {
        private AgentService agentService = new AgentService();
        private ItemService itemService = new ItemService();
        private OrderService orderService = new OrderService();

        private List<OrderDetail> OrderItems
        {
            get => (List<OrderDetail>)ViewState["OrderItems"] ?? new List<OrderDetail>();
            set => ViewState["OrderItems"] = value;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlAgents.DataSource = agentService.GetAllAgents();
                ddlAgents.DataTextField = "AgentName";
                ddlAgents.DataValueField = "AgentID";
                ddlAgents.DataBind();

                ddlItems.DataSource = itemService.GetAllItems();
                ddlItems.DataTextField = "ItemName";
                ddlItems.DataValueField = "ItemID";
                ddlItems.DataBind();
            }
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            var selectedItemID = int.Parse(ddlItems.SelectedValue);
            var selectedItemName = ddlItems.SelectedItem.Text;
            var quantity = int.Parse(txtQuantity.Text);
            var unitAmount = decimal.Parse(txtUnitAmount.Text);

            var orderDetail = new OrderDetail
            {
                ItemID = selectedItemID,
                Quantity = quantity,
                UnitAmount = unitAmount,
                Item = new Item { ItemName = selectedItemName } // for display
            };

            var currentList = OrderItems;
            currentList.Add(orderDetail);
            OrderItems = currentList;

            BindOrderGrid();
        }

        private void BindOrderGrid()
        {
            var displayData = OrderItems.Select(od => new
            {
                od.ItemID,
                ItemName = od.Item.ItemName,
                od.Quantity,
                od.UnitAmount
            }).ToList();

            gvOrderDetails.DataSource = displayData;
            gvOrderDetails.DataBind();
        }

        protected void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                AgentID = int.Parse(ddlAgents.SelectedValue),
                OrderDate = DateTime.Now,
                OrderDetails = OrderItems
            };

            orderService.CreateOrder(order);

            lblMessage.Text = "Order submitted successfully!";
            OrderItems = new List<OrderDetail>();
            gvOrderDetails.DataSource = null;
            gvOrderDetails.DataBind();
        }
    }
}
