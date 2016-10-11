using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Channel_Queue
{
    static class SimSystem
    {
        public static List<Server> Servers = new List<Server>(0);
        public static List<Customer> Customers = new List<Customer>(0);
        public static Queue<Customer> WaitingQueue = new Queue<Customer>();


    }
    public class ServerServiceTimeDistribution
    {
        public int service_time;
        public float probability;
        public float cumulative_probability;
        public KeyValuePair<int, int> Range;

        public ServerServiceTimeDistribution(int service_time=0, float probability=0.0f, float cumulative_probability=0.0f)
        {
            this.service_time = service_time;
            this.probability = probability;
            this.cumulative_probability = cumulative_probability;
        }
    }
}
