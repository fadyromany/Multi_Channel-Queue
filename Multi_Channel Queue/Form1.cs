using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Multi_Channel_Queue
{
    public partial class Form1 : Form
    {
        int number_of_servers = 0;
        int number_of_customers = 0;
        string server_selection = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Simulate_Click(object sender, EventArgs e)
        {
            CreateCustomers(number_of_customers);
        }

        private void CreateCustomers(int number_of_customers)
        {
            for (int i = 0; i < number_of_customers; i++)
            {
                Customer customer = new Customer();

                SimSystem.Customers.Add(customer);
            }
        }

        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                number_of_servers = int.Parse(TB_Number_of_servers.Text);
                TB_Number_of_customers.ReadOnly = true;
                number_of_customers = int.Parse(TB_Number_of_customers.Text);
                TB_Number_of_servers.ReadOnly = true;
                server_selection = CB_Server_selection.SelectedItem.ToString();
                CB_Server_selection.Enabled = false;
                if (number_of_servers != SimSystem.Servers.Count)
                {
                    Server server = new Server(TB_Server_name.Text);
                    calculate_rows_for_server(server);
                    SimSystem.Servers.Add(server);
                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        private void calculate_rows_for_server(Server server)
        {
            for (int i = 0; i < DGV_Server_distribution_service_time.Rows.Count - 1; i++)
            {

                ServerServiceTimeDistribution s = new ServerServiceTimeDistribution();
                s.service_time = int.Parse(DGV_Server_distribution_service_time.Rows[i].Cells[0].Value.ToString());
                s.probability = float.Parse(DGV_Server_distribution_service_time.Rows[i].Cells[1].Value.ToString());
                try
                {
                    float prev_cumulative = server.getPreviousServerServiceTimeDistribution(s).cumulative_probability;
                    s.cumulative_probability = prev_cumulative + s.probability;
                    s.Range = new KeyValuePair<int, int>((int)(prev_cumulative * 100), (int)(s.cumulative_probability * 100));
                }
                catch (Exception)
                {
                    throw;
                }
                server.addServerServiceTimeDistribution(s);
                DGV_Server_distribution_service_time.Rows[i].Cells[2].Value = s.cumulative_probability.ToString();
                DGV_Server_distribution_service_time.Rows[i].Cells[3].Value = string.Format("{0} - {1}", s.Range.Key, s.Range.Value).ToString();

            }
        }       
    }
}
