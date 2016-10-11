using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Channel_Queue
{
    class Customer
    {
        private int delay_time;
        private int service_time_begin;
        private int service_time_end;
        private int service_duration=0;
        private int server_index;
        private int arrival_time;
        private int inter_arrival_time;
        public static int getTotalDelayTime()
        {
            int Total = 0;
            foreach (Customer c in SimSystem.Customers)
            {
                Total+=c.delay_time;
            }
            return Total;
        }
        public static int getTotalCustomers()
        {
            return SimSystem.Customers.Count;
        }

        public Customer(int delay_time=0, int service_time_begin=0, int service_time_end=0, int service_duration=0, int server_index=-1, int arrival_time=0, int inter_arrival_time=0)
        {
            this.delay_time = delay_time;
            this.service_time_begin = service_time_begin;
            this.service_time_end = service_time_end;
            this.service_duration = service_duration;
            this.server_index = server_index;
            this.arrival_time = arrival_time;
            this.inter_arrival_time = inter_arrival_time;
            SimSystem.Customers.Add(this);
        }
        public Customer getNext(Customer c)
        {
           int i = SimSystem.Customers.IndexOf(c)+1;
            try
            {
                Customer customer = SimSystem.Customers[i];
            }
            catch (Exception)
            {

                return null;
            }

            return SimSystem.Customers[i];
        }
        public Customer getPrevious(Customer c)
        {
            int i = SimSystem.Customers.IndexOf(c) - 1;
            try
            {
                Customer customer = SimSystem.Customers[i];
            }
            catch (Exception)
            {

                return null;
            }

            return SimSystem.Customers[i];
        }
        public int getDelayTime()
        {
            return this.delay_time;
        }
        public int getServiceTimeBegin()
        {
            return this.service_time_begin;
        }
        public int getServiceTimeEnd()
        {
            return this.service_time_end;
        }
        public int getServiceDuration()
        {
            if (this.service_duration==0)
            {
                this.service_duration = this.service_time_end - this.service_time_begin; 
            }
            return this.service_duration;
        }
        public void setDelayTime(int Time)
        {
            this.delay_time = Time;
        }
        public void getServiceTimeEnd(int Time)
        {
            this.service_time_end = Time;
        }
        public void getServiceTimeBegin(int Time)
        {
            this.service_time_begin = Time;
        }




    }

}
