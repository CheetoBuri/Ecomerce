using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebUI
{
    public partial class Agent : System.Web.UI.Page
    {
        private readonly AgentService _agentService = new AgentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvAgents.DataSource = _agentService.GetAllAgents();
                gvAgents.DataBind();
            }
        }
    }
}