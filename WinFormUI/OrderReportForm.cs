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

namespace WinFormUI
{
    public partial class OrderReportForm : Form
    {
        private OrderService orderService;
        public OrderReportForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            cmbOrder.DataSource = orderService.GetAllOrders();
            cmbOrder.DisplayMember = "OrderID";
            cmbOrder.ValueMember = "OrderID";
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            int orderId = (int)cmbOrder.SelectedValue;
            var details = orderService.GetOrderDetails(orderId);
            dgvOrderDetails.DataSource = details;
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // For simplicity, just show a message (you can use PrintDocument for real printing)
                MessageBox.Show("Printing Order...");
            }
        }
    }
}
