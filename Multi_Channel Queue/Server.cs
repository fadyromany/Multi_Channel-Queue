using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Channel_Queue
{


    class Server
    {
        private string name;
        private int idle_time = 0;
        private int total_service_time = 0;
        private int priority = 0;
        private int index = 0;
        private List<Customer> Served_Customer = new List<Customer>(0);
        private List<ServerServiceTimeDistribution> Time_Distribution = new List<ServerServiceTimeDistribution>();
        public Server(string name = "")
        {
            this.name = name;
        }
        public void addServerServiceTimeDistribution(ServerServiceTimeDistribution serverServiceTimeDistribution)
        {
            this.Time_Distribution.Add(serverServiceTimeDistribution);
        }
        public ServerServiceTimeDistribution getPreviousServerServiceTimeDistribution(ServerServiceTimeDistribution serverServiceTimeDistribution)
        {
            ServerServiceTimeDistribution s = new ServerServiceTimeDistribution();
            try
            {
                s = this.Time_Distribution[this.Time_Distribution.Count - 1];
            }
            catch (Exception)
            {
                return s;
            }
            return s;
        }
        public int getTotalIdleTime()
        {
            return idle_time;
        }
        public int getTotalServiceTime()
        {
            return total_service_time;
        }
        public int getPriorityIndex()
        {
            return priority;
        }
        public int getTotalServedCustomers()
        {
            return Served_Customer.Count;
        }

    }
}
