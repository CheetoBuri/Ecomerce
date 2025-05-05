using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormUI
{
    public partial class OrderForm : Form
    {
        private AgentService agentService;
        private ItemService itemService;
        private OrderService orderService;
        private OrderDetailService orderDetailService;
        private List<OrderDetail> orderDetails;
        public OrderForm()
        {
            InitializeComponent();
            agentService = new AgentService();
            itemService = new ItemService();
            orderService = new OrderService();
            orderDetailService = new OrderDetailService();
            orderDetails = new List<OrderDetail>();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            cmbAgent.DataSource = agentService.GetAllAgents();
            cmbAgent.DisplayMember = "AgentName";
            cmbAgent.ValueMember = "AgentID";

            cmbItem.DataSource = itemService.GetAllItems();
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var detail = new OrderDetail
            {
                ItemID = (int)cmbItem.SelectedValue,
                Quantity = int.Parse(txtQuantity.Text),
                UnitAmount = decimal.Parse(txtUnitAmount.Text)
            };
            orderDetails.Add(detail);
            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = orderDetails;
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                AgentID = (int)cmbAgent.SelectedValue,
                TotalAmount = CalculateTotal()
            };
            orderService.PlaceOrder(order);

            foreach (var detail in orderDetails)
            {
                detail.OrderID = order.OrderID; // OrderID must be set after inserting Order
                orderDetailService.AddOrderDetail(detail);
            }

            MessageBox.Show("Order saved!");
        }

        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var detail in orderDetails)
            {
                total += detail.Quantity * detail.UnitAmount;
            }
            return total;
        }
    }
}
