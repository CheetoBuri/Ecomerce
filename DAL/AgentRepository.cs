using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using DAL.Models;

namespace DAL
{
    public class AgentRepository
    {
        public List<Agent> GetAllAgents()
        {
            var agents = new List<Agent>();
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("SELECT * FROM Agent", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    agents.Add(new Agent
                    {
                        AgentID = (int)reader["AgentID"],
                        AgentName = reader["AgentName"].ToString(),
                        Address = reader["Address"].ToString(),
                        Phone = reader["Phone"].ToString()
                    });
                }
            }
            return agents;
        }

        public void InsertAgent(Agent agent)
        {
            using (var conn = DBHelper.GetConnection())
            {
                var cmd = new SqlCommand("INSERT INTO Agent (AgentID, AgentName, Address, Phone) VALUES (@AgentID, @AgentName, @Address, @Phone)", conn);
                cmd.Parameters.AddWithValue("@AgentID", agent.AgentID);
                cmd.Parameters.AddWithValue("@AgentName", agent.AgentName);
                cmd.Parameters.AddWithValue("@Address", agent.Address);
                cmd.Parameters.AddWithValue("@Phone", agent.Phone);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

