namespace Multi_Channel_Queue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Number_of_servers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Server_selection = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Simulate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Number_of_customers = new System.Windows.Forms.TextBox();
            this.DGV_Server_distribution_service_time = new System.Windows.Forms.DataGridView();
            this.DGV_Inter_arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Cumulative_probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Server_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Server_distribution_service_time)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Number_of_servers
            // 
            this.TB_Number_of_servers.Location = new System.Drawing.Point(123, 6);
            this.TB_Number_of_servers.Name = "TB_Number_of_servers";
            this.TB_Number_of_servers.Size = new System.Drawing.Size(100, 20);
            this.TB_Number_of_servers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of servers";
            // 
            // CB_Server_selection
            // 
            this.CB_Server_selection.FormattingEnabled = true;
            this.CB_Server_selection.Items.AddRange(new object[] {
            "Highest Priority",
            "Random",
            "Lowest utilization"});
            this.CB_Server_selection.Location = new System.Drawing.Point(123, 32);
            this.CB_Server_selection.Name = "CB_Server_selection";
            this.CB_Server_selection.Size = new System.Drawing.Size(121, 21);
            this.CB_Server_selection.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server selection";
            // 
            // BTN_Simulate
            // 
            this.BTN_Simulate.Location = new System.Drawing.Point(587, 457);
            this.BTN_Simulate.Name = "BTN_Simulate";
            this.BTN_Simulate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Simulate.TabIndex = 4;
            this.BTN_Simulate.Text = "Simulate";
            this.BTN_Simulate.UseVisualStyleBackColor = true;
            this.BTN_Simulate.Click += new System.EventHandler(this.BTN_Simulate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of customers";
            // 
            // TB_Number_of_customers
            // 
            this.TB_Number_of_customers.Location = new System.Drawing.Point(123, 59);
            this.TB_Number_of_customers.Name = "TB_Number_of_customers";
            this.TB_Number_of_customers.Size = new System.Drawing.Size(100, 20);
            this.TB_Number_of_customers.TabIndex = 6;
            // 
            // DGV_Server_distribution_service_time
            // 
            this.DGV_Server_distribution_service_time.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Server_distribution_service_time.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Inter_arrival_time,
            this.DGV_Probability,
            this.DGV_Cumulative_probability,
            this.DGV_Range});
            this.DGV_Server_distribution_service_time.Location = new System.Drawing.Point(15, 118);
            this.DGV_Server_distribution_service_time.Name = "DGV_Server_distribution_service_time";
            this.DGV_Server_distribution_service_time.Size = new System.Drawing.Size(443, 213);
            this.DGV_Server_distribution_service_time.TabIndex = 7;
            // 
            // DGV_Inter_arrival_time
            // 
            this.DGV_Inter_arrival_time.HeaderText = "Inter-Arrival Time";
            this.DGV_Inter_arrival_time.Name = "DGV_Inter_arrival_time";
            // 
            // DGV_Probability
            // 
            this.DGV_Probability.HeaderText = "Probability";
            this.DGV_Probability.Name = "DGV_Probability";
            // 
            // DGV_Cumulative_probability
            // 
            this.DGV_Cumulative_probability.HeaderText = "Cumulaitive Probability";
            this.DGV_Cumulative_probability.Name = "DGV_Cumulative_probability";
            this.DGV_Cumulative_probability.ReadOnly = true;
            // 
            // DGV_Range
            // 
            this.DGV_Range.HeaderText = "Range";
            this.DGV_Range.Name = "DGV_Range";
            this.DGV_Range.ReadOnly = true;
            // 
            // BTN_Calculate
            // 
            this.BTN_Calculate.Location = new System.Drawing.Point(274, 358);
            this.BTN_Calculate.Name = "BTN_Calculate";
            this.BTN_Calculate.Size = new System.Drawing.Size(75, 23);
            this.BTN_Calculate.TabIndex = 8;
            this.BTN_Calculate.Text = "Calculate";
            this.BTN_Calculate.UseVisualStyleBackColor = true;
            this.BTN_Calculate.Click += new System.EventHandler(this.BTN_Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Server name";
            // 
            // TB_Server_name
            // 
            this.TB_Server_name.Location = new System.Drawing.Point(123, 360);
            this.TB_Server_name.Name = "TB_Server_name";
            this.TB_Server_name.Size = new System.Drawing.Size(100, 20);
            this.TB_Server_name.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 492);
            this.Controls.Add(this.TB_Server_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Calculate);
            this.Controls.Add(this.DGV_Server_distribution_service_time);
            this.Controls.Add(this.TB_Number_of_customers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Simulate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Server_selection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Number_of_servers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Server_distribution_service_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Number_of_servers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Server_selection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Simulate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Number_of_customers;
        private System.Windows.Forms.DataGridView DGV_Server_distribution_service_time;
        private System.Windows.Forms.Button BTN_Calculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Inter_arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Cumulative_probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Range;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Server_name;
    }
}

