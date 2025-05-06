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
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        private void OrderReportForm_Load(object sender, EventArgs e)
        {
            var orderService = new OrderService();
            var orders = orderService.GetAllOrders();
            
            cmbOrder.DataSource = orderService.GetAllOrders();
            cmbOrder.DisplayMember = "OrderID";
            cmbOrder.ValueMember = "OrderID";

            dgvOrderDetails.DataSource = orders.Select(o => new
            {
                o.OrderID,
                o.OrderDate,
                AgentName = o.Agent.AgentName
            }).ToList();
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

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 100;
            int x = 50;
            int rowHeight = 30;

            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Header
            e.Graphics.DrawString("Order Report", new Font("Arial", 16, FontStyle.Bold), brush, x, y);
            y += 40;

            // Column titles
            e.Graphics.DrawString("Order ID", font, brush, x, y);
            e.Graphics.DrawString("Order Date", font, brush, x + 100, y);
            e.Graphics.DrawString("Agent", font, brush, x + 250, y);
            y += rowHeight;

            // Data rows
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["OrderID"].Value.ToString(), font, brush, x, y);
                e.Graphics.DrawString(Convert.ToDateTime(row.Cells["OrderDate"].Value).ToShortDateString(), font, brush, x + 100, y);
                e.Graphics.DrawString(row.Cells["AgentName"].Value.ToString(), font, brush, x + 250, y);
                y += rowHeight;
            }
        }
    }
}
