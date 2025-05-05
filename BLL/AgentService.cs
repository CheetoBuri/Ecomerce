using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using DAL;
using DAL.Models;

namespace BLL
{
    public class AgentService
    {
        private AgentRepository agentRepository;

        public AgentService()
        {
            agentRepository = new AgentRepository();
        }

        public List<Agent> GetAllAgents()
        {
            return agentRepository.GetAllAgents();
        }

        public void AddAgent(Agent agent)
        {
            agentRepository.InsertAgent(agent);
        }
    }
}
