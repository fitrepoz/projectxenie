using System.Collections.Generic;
using System.Linq;

namespace Homeology.API.Models
{
    public class AgentsRepository
    {
        private static HomeologyEntities homeologyContext = new HomeologyEntities();
        public static List<Agent> GetAllAgents()
        {
            var query = from agent in homeologyContext.Agents
                        select agent;
            return query.ToList();
        }

        public static List<Agent> SearchAgentsByName(string agentName)
        {
            var query = from agent in homeologyContext.Agents
                        where agent.first_name.Contains(agentName)
                        select agent;
            return query.ToList();
        }

        public static Agent GetAgent(int agentId)
        {
            var query = from agent in homeologyContext.Agents
                        where agent.agent_id == agentId
                        select agent;
            return query.SingleOrDefault();
        }

        public static List<Agent> InsertAgent(Agent e)
        {
            homeologyContext.Agents.Add(e);
            homeologyContext.SaveChanges();
            return GetAllAgents();
        }

        public static List<Agent> UpdateAgent(Agent e)
        {
            var emp = (from agent in homeologyContext.Agents
                       where agent.agent_id == e.agent_id
                       select agent).SingleOrDefault();
            emp.first_name = e.first_name;
            emp.last_name = e.last_name;
            emp.agent_email = e.agent_email;
            emp.agent_phone = e.agent_phone;
            emp.agent_status = e.agent_status;
            emp.agent_company = e.agent_company;
            homeologyContext.SaveChanges();
            return GetAllAgents();
        }

        public static List<Agent> DeleteAgent(Agent e)
        {
            var emp = (from agent in homeologyContext.Agents
                       where agent.agent_id == e.agent_id
                       select agent).SingleOrDefault();
            homeologyContext.Agents.Remove(emp);
            homeologyContext.SaveChanges();
            return GetAllAgents();
        }
    }
}