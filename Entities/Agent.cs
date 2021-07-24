using System; 

namespace SalesAgent.Entities
{
    public class Agent
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public DateTime BirthDate { get; set; }
        public string AgentId { get; private set; }

        public Agent(string name, string lastName, string email, string addres, DateTime birthDate, string agentId)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Addres = addres;
            BirthDate = birthDate;
            AgentId = agentId;
        }

    }
}