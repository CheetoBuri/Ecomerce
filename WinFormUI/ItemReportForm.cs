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
    public partial class ItemReportForm : Form
    {
        private ItemService itemService;
        private AgentService agentService;
        public ItemReportForm()
        {
            InitializeComponent();
            itemService = new ItemService();
            agentService = new AgentService();
        }

        private void ItemReportForm_Load(object sender, EventArgs e)
        {
            cmbAgents.DataSource = agentService.GetAllAgents();
            cmbAgents.DisplayMember = "AgentName";
            cmbAgents.ValueMember = "AgentID";
        }

        private void btnShowBestItems_Click(object sender, EventArgs e)
        {
            var bestItems = itemService.GetTopSellingItems();
            dgvReport.DataSource = bestItems;
        }

        private void btnShowAgentItems_Click(object sender, EventArgs e)
        {
            int agentId = (int)cmbAgents.SelectedValue;
            var agentItems = itemService.GetItemsByAgent(agentId);
            dgvReport.DataSource = agentItems;
        }

        private void btnShowAgentPurchases_Click(object sender, EventArgs e)
        {
            int agentId = (int)cmbAgents.SelectedValue;
            var agentPurchases = itemService.GetAgentPurchaseSummary(agentId);
            dgvReport.DataSource = agentPurchases;
        }
    }
}
