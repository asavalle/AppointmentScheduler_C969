
namespace AppointmentScheduler_C969.Views
{
    partial class Dashboard
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
            this.dashTabControl = new System.Windows.Forms.TabControl();
            this.tab_Appointments = new System.Windows.Forms.TabPage();
            this.btn_AddApt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_showByWeek = new System.Windows.Forms.Button();
            this.btn_showByMonth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.btn_DelApt = new System.Windows.Forms.Button();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.btn_DelCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.tab_Tools = new System.Windows.Forms.TabPage();
            this.gb_Reports = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_loginLogs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_aptTypesMonth = new System.Windows.Forms.Button();
            this.btn_sheduleByUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lb_user = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dashTabControl.SuspendLayout();
            this.tab_Appointments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.tab_Tools.SuspendLayout();
            this.gb_Reports.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashTabControl
            // 
            this.dashTabControl.Controls.Add(this.tab_Appointments);
            this.dashTabControl.Controls.Add(this.tab_Customers);
            this.dashTabControl.Controls.Add(this.tab_Tools);
            this.dashTabControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashTabControl.Location = new System.Drawing.Point(2, 67);
            this.dashTabControl.Name = "dashTabControl";
            this.dashTabControl.SelectedIndex = 0;
            this.dashTabControl.Size = new System.Drawing.Size(1318, 748);
            this.dashTabControl.TabIndex = 0;
            // 
            // tab_Appointments
            // 
            this.tab_Appointments.Controls.Add(this.btn_AddApt);
            this.tab_Appointments.Controls.Add(this.groupBox1);
            this.tab_Appointments.Controls.Add(this.label3);
            this.tab_Appointments.Controls.Add(this.dgv_Appointments);
            this.tab_Appointments.Controls.Add(this.btn_DelApt);
            this.tab_Appointments.Location = new System.Drawing.Point(4, 23);
            this.tab_Appointments.Name = "tab_Appointments";
            this.tab_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Appointments.Size = new System.Drawing.Size(1310, 721);
            this.tab_Appointments.TabIndex = 0;
            this.tab_Appointments.Text = "Appointments";
            this.tab_Appointments.UseVisualStyleBackColor = true;
            // 
            // btn_AddApt
            // 
            this.btn_AddApt.BackColor = System.Drawing.Color.LightBlue;
            this.btn_AddApt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddApt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AddApt.Location = new System.Drawing.Point(1123, 672);
            this.btn_AddApt.Name = "btn_AddApt";
            this.btn_AddApt.Size = new System.Drawing.Size(83, 42);
            this.btn_AddApt.TabIndex = 9;
            this.btn_AddApt.Text = "Add New";
            this.btn_AddApt.UseVisualStyleBackColor = false;
            this.btn_AddApt.Click += new System.EventHandler(this.btn_AddApt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btn_showAll);
            this.groupBox1.Controls.Add(this.btn_showByWeek);
            this.groupBox1.Controls.Add(this.btn_showByMonth);
            this.groupBox1.Location = new System.Drawing.Point(1035, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Appointments";
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_showAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showAll.Location = new System.Drawing.Point(6, 31);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(75, 27);
            this.btn_showAll.TabIndex = 8;
            this.btn_showAll.Text = "All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            // 
            // btn_showByWeek
            // 
            this.btn_showByWeek.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showByWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showByWeek.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showByWeek.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showByWeek.Location = new System.Drawing.Point(186, 31);
            this.btn_showByWeek.Name = "btn_showByWeek";
            this.btn_showByWeek.Size = new System.Drawing.Size(75, 27);
            this.btn_showByWeek.TabIndex = 7;
            this.btn_showByWeek.Text = "Week";
            this.btn_showByWeek.UseVisualStyleBackColor = false;
            // 
            // btn_showByMonth
            // 
            this.btn_showByMonth.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showByMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_showByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showByMonth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showByMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showByMonth.Location = new System.Drawing.Point(96, 31);
            this.btn_showByMonth.Name = "btn_showByMonth";
            this.btn_showByMonth.Size = new System.Drawing.Size(75, 27);
            this.btn_showByMonth.TabIndex = 6;
            this.btn_showByMonth.Text = "Month";
            this.btn_showByMonth.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Appointments Scheduled";
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.AllowUserToResizeColumns = false;
            this.dgv_Appointments.AllowUserToResizeRows = false;
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.Location = new System.Drawing.Point(7, 77);
            this.dgv_Appointments.MultiSelect = false;
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Appointments.RowTemplate.Height = 25;
            this.dgv_Appointments.Size = new System.Drawing.Size(1297, 511);
            this.dgv_Appointments.TabIndex = 3;
            // 
            // btn_DelApt
            // 
            this.btn_DelApt.BackColor = System.Drawing.Color.Crimson;
            this.btn_DelApt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DelApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DelApt.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_DelApt.Location = new System.Drawing.Point(1221, 672);
            this.btn_DelApt.Name = "btn_DelApt";
            this.btn_DelApt.Size = new System.Drawing.Size(83, 42);
            this.btn_DelApt.TabIndex = 2;
            this.btn_DelApt.Text = "Delete";
            this.btn_DelApt.UseVisualStyleBackColor = false;
            // 
            // tab_Customers
            // 
            this.tab_Customers.Controls.Add(this.label2);
            this.tab_Customers.Controls.Add(this.dgv_Customers);
            this.tab_Customers.Controls.Add(this.btn_DelCustomer);
            this.tab_Customers.Controls.Add(this.btn_AddCustomer);
            this.tab_Customers.Location = new System.Drawing.Point(4, 23);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(1310, 721);
            this.tab_Customers.TabIndex = 2;
            this.tab_Customers.Text = "Customers";
            this.tab_Customers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customers";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToDeleteRows = false;
            this.dgv_Customers.AllowUserToResizeColumns = false;
            this.dgv_Customers.AllowUserToResizeRows = false;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(7, 77);
            this.dgv_Customers.MultiSelect = false;
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.RowTemplate.Height = 25;
            this.dgv_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customers.Size = new System.Drawing.Size(1297, 511);
            this.dgv_Customers.TabIndex = 2;
            // 
            // btn_DelCustomer
            // 
            this.btn_DelCustomer.Location = new System.Drawing.Point(1190, 660);
            this.btn_DelCustomer.Name = "btn_DelCustomer";
            this.btn_DelCustomer.Size = new System.Drawing.Size(114, 54);
            this.btn_DelCustomer.TabIndex = 1;
            this.btn_DelCustomer.Text = "Delete";
            this.btn_DelCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Location = new System.Drawing.Point(1039, 660);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(114, 54);
            this.btn_AddCustomer.TabIndex = 0;
            this.btn_AddCustomer.Text = "Add New";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // tab_Tools
            // 
            this.tab_Tools.Controls.Add(this.groupBox2);
            this.tab_Tools.Controls.Add(this.gb_Reports);
            this.tab_Tools.Location = new System.Drawing.Point(4, 23);
            this.tab_Tools.Name = "tab_Tools";
            this.tab_Tools.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tools.Size = new System.Drawing.Size(1310, 721);
            this.tab_Tools.TabIndex = 3;
            this.tab_Tools.Text = "Tools";
            this.tab_Tools.UseVisualStyleBackColor = true;
            // 
            // gb_Reports
            // 
            this.gb_Reports.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_Reports.Controls.Add(this.label6);
            this.gb_Reports.Controls.Add(this.btn_loginLogs);
            this.gb_Reports.Controls.Add(this.label5);
            this.gb_Reports.Controls.Add(this.label4);
            this.gb_Reports.Controls.Add(this.btn_aptTypesMonth);
            this.gb_Reports.Controls.Add(this.btn_sheduleByUser);
            this.gb_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Reports.Location = new System.Drawing.Point(918, 24);
            this.gb_Reports.Name = "gb_Reports";
            this.gb_Reports.Size = new System.Drawing.Size(381, 326);
            this.gb_Reports.TabIndex = 3;
            this.gb_Reports.TabStop = false;
            this.gb_Reports.Text = "Reports";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(77, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Login Report by User";
            // 
            // btn_loginLogs
            // 
            this.btn_loginLogs.Location = new System.Drawing.Point(272, 230);
            this.btn_loginLogs.Name = "btn_loginLogs";
            this.btn_loginLogs.Size = new System.Drawing.Size(103, 41);
            this.btn_loginLogs.TabIndex = 5;
            this.btn_loginLogs.Text = "Report";
            this.btn_loginLogs.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Schedule by User / Consultant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Types by Month";
            // 
            // btn_aptTypesMonth
            // 
            this.btn_aptTypesMonth.Location = new System.Drawing.Point(272, 45);
            this.btn_aptTypesMonth.Name = "btn_aptTypesMonth";
            this.btn_aptTypesMonth.Size = new System.Drawing.Size(103, 41);
            this.btn_aptTypesMonth.TabIndex = 1;
            this.btn_aptTypesMonth.Text = "Report";
            this.btn_aptTypesMonth.UseVisualStyleBackColor = true;
            // 
            // btn_sheduleByUser
            // 
            this.btn_sheduleByUser.Location = new System.Drawing.Point(272, 140);
            this.btn_sheduleByUser.Name = "btn_sheduleByUser";
            this.btn_sheduleByUser.Size = new System.Drawing.Size(103, 41);
            this.btn_sheduleByUser.TabIndex = 2;
            this.btn_sheduleByUser.Text = "Report";
            this.btn_sheduleByUser.UseVisualStyleBackColor = true;
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(6, 44);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(103, 41);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Scheduler";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.Location = new System.Drawing.Point(1235, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(1223, 49);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(82, 15);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "logged in user";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn_AddUser);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(43, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User / Consultant Management";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modify User";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1322, 816);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashTabControl);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Scheduler Dashboard";
            this.dashTabControl.ResumeLayout(false);
            this.tab_Appointments.ResumeLayout(false);
            this.tab_Appointments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            this.tab_Customers.ResumeLayout(false);
            this.tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.tab_Tools.ResumeLayout(false);
            this.gb_Reports.ResumeLayout(false);
            this.gb_Reports.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dashTabControl;
        private System.Windows.Forms.TabPage tab_Appointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Button btn_DelCustomer;
        private System.Windows.Forms.Button btn_DelApt;
        private System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.GroupBox gb_addAptForm;
        private System.Windows.Forms.TextBox tb_aptDesc;
        private System.Windows.Forms.TextBox tb_aptTitle;
        private System.Windows.Forms.TextBox tb_aptID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.Button btn_showByWeek;
        private System.Windows.Forms.Button btn_showByMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_aptID;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.Label lb_aptTitle;
        private System.Windows.Forms.Label lb_aptDesc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_aptDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lb_endTime;
        private System.Windows.Forms.Label lb_startTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_AddApt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_aptType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_aptLocation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_aptURL;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TabPage tab_Tools;
        private System.Windows.Forms.Button btn_sheduleByUser;
        private System.Windows.Forms.Button btn_aptTypesMonth;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.GroupBox gb_Reports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_loginLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}