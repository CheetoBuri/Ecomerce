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


namespace WinFormUI
{
    public partial class AgentForm : Form
    {
        private AgentService agentService;
        public AgentForm()
        {
            InitializeComponent();
            agentService = new AgentService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var agent = new Agent
            {
                AgentName = txtAgentName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text
            };

            agentService.AddAgent(agent);
            MessageBox.Show("Agent saved!");
        }
    }
}
