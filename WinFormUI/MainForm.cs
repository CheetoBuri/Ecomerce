using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.ShowDialog();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            AgentForm form = new AgentForm();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OrderReportForm form = new OrderReportForm();
            form.ShowDialog();
        }
    }
}
