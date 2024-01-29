
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
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_searchByDoc = new System.Windows.Forms.TextBox();
            this.tb_searchByPatient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_currentView = new System.Windows.Forms.Label();
            this.btn_ModAppt = new System.Windows.Forms.Button();
            this.btn_AddApt = new System.Windows.Forms.Button();
            this.gb_filterAppointments = new System.Windows.Forms.GroupBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_showByWeek = new System.Windows.Forms.Button();
            this.btn_showByMonth = new System.Windows.Forms.Button();
            this.lb_Appointments = new System.Windows.Forms.Label();
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.btn_DelApt = new System.Windows.Forms.Button();
            this.tab_Customers = new System.Windows.Forms.TabPage();
            this.btn_delAddress = new System.Windows.Forms.Button();
            this.dgv_addresses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DelCustomer = new System.Windows.Forms.Button();
            this.btn_ModCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.lb_Customers = new System.Windows.Forms.Label();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.tab_Tools = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_loginReport = new System.Windows.Forms.TextBox();
            this.lb_Users = new System.Windows.Forms.Label();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delUser = new System.Windows.Forms.Button();
            this.btn_modUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.gb_Reports = new System.Windows.Forms.GroupBox();
            this.lb_aptsByCity = new System.Windows.Forms.Label();
            this.btn_aptsByCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_loginLogs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_aptTypesMonth = new System.Windows.Forms.Button();
            this.btn_sheduleByUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lb_user = new System.Windows.Forms.Label();
            this.dashTabControl.SuspendLayout();
            this.tab_Appointments.SuspendLayout();
            this.gb_filterAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            this.tab_Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.tab_Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gb_Reports.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashTabControl
            // 
            this.dashTabControl.Controls.Add(this.tab_Appointments);
            this.dashTabControl.Controls.Add(this.tab_Customers);
            this.dashTabControl.Controls.Add(this.tab_Tools);
            this.dashTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashTabControl.Location = new System.Drawing.Point(2, 67);
            this.dashTabControl.Name = "dashTabControl";
            this.dashTabControl.SelectedIndex = 0;
            this.dashTabControl.Size = new System.Drawing.Size(1318, 748);
            this.dashTabControl.TabIndex = 0;
            // 
            // tab_Appointments
            // 
            this.tab_Appointments.BackColor = System.Drawing.Color.AliceBlue;
            this.tab_Appointments.Controls.Add(this.btn_search);
            this.tab_Appointments.Controls.Add(this.tb_searchByDoc);
            this.tab_Appointments.Controls.Add(this.tb_searchByPatient);
            this.tab_Appointments.Controls.Add(this.label10);
            this.tab_Appointments.Controls.Add(this.label9);
            this.tab_Appointments.Controls.Add(this.label8);
            this.tab_Appointments.Controls.Add(this.lb_currentView);
            this.tab_Appointments.Controls.Add(this.btn_ModAppt);
            this.tab_Appointments.Controls.Add(this.btn_AddApt);
            this.tab_Appointments.Controls.Add(this.gb_filterAppointments);
            this.tab_Appointments.Controls.Add(this.lb_Appointments);
            this.tab_Appointments.Controls.Add(this.dgv_Appointments);
            this.tab_Appointments.Controls.Add(this.btn_DelApt);
            this.tab_Appointments.Location = new System.Drawing.Point(4, 24);
            this.tab_Appointments.Name = "tab_Appointments";
            this.tab_Appointments.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Appointments.Size = new System.Drawing.Size(1310, 720);
            this.tab_Appointments.TabIndex = 0;
            this.tab_Appointments.Text = "Appointments";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(907, 42);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_searchByDoc
            // 
            this.tb_searchByDoc.Location = new System.Drawing.Point(733, 42);
            this.tb_searchByDoc.Name = "tb_searchByDoc";
            this.tb_searchByDoc.Size = new System.Drawing.Size(152, 21);
            this.tb_searchByDoc.TabIndex = 15;
            // 
            // tb_searchByPatient
            // 
            this.tb_searchByPatient.Location = new System.Drawing.Point(498, 42);
            this.tb_searchByPatient.Name = "tb_searchByPatient";
            this.tb_searchByPatient.Size = new System.Drawing.Size(163, 21);
            this.tb_searchByPatient.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(733, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Search By Doctor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "OR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(498, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Search By Patient";
            // 
            // lb_currentView
            // 
            this.lb_currentView.AutoSize = true;
            this.lb_currentView.BackColor = System.Drawing.Color.Transparent;
            this.lb_currentView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_currentView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_currentView.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_currentView.Location = new System.Drawing.Point(10, 7);
            this.lb_currentView.Name = "lb_currentView";
            this.lb_currentView.Size = new System.Drawing.Size(277, 19);
            this.lb_currentView.TabIndex = 4;
            this.lb_currentView.Text = "Currently viewing all appointments.";
            // 
            // btn_ModAppt
            // 
            this.btn_ModAppt.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ModAppt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModAppt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ModAppt.Location = new System.Drawing.Point(1132, 594);
            this.btn_ModAppt.Name = "btn_ModAppt";
            this.btn_ModAppt.Size = new System.Drawing.Size(83, 42);
            this.btn_ModAppt.TabIndex = 10;
            this.btn_ModAppt.Text = "Modify";
            this.btn_ModAppt.UseVisualStyleBackColor = false;
            this.btn_ModAppt.Click += new System.EventHandler(this.btn_ModAppt_Click);
            // 
            // btn_AddApt
            // 
            this.btn_AddApt.BackColor = System.Drawing.Color.LightBlue;
            this.btn_AddApt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddApt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AddApt.Location = new System.Drawing.Point(1043, 594);
            this.btn_AddApt.Name = "btn_AddApt";
            this.btn_AddApt.Size = new System.Drawing.Size(83, 42);
            this.btn_AddApt.TabIndex = 9;
            this.btn_AddApt.Text = "Add New";
            this.btn_AddApt.UseVisualStyleBackColor = false;
            this.btn_AddApt.Click += new System.EventHandler(this.btn_AddApt_Click);
            // 
            // gb_filterAppointments
            // 
            this.gb_filterAppointments.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_filterAppointments.Controls.Add(this.btn_showAll);
            this.gb_filterAppointments.Controls.Add(this.btn_showByWeek);
            this.gb_filterAppointments.Controls.Add(this.btn_showByMonth);
            this.gb_filterAppointments.Location = new System.Drawing.Point(1035, 7);
            this.gb_filterAppointments.Name = "gb_filterAppointments";
            this.gb_filterAppointments.Size = new System.Drawing.Size(269, 64);
            this.gb_filterAppointments.TabIndex = 8;
            this.gb_filterAppointments.TabStop = false;
            this.gb_filterAppointments.Text = "Filter Appointments";
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_showAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showAll.Location = new System.Drawing.Point(6, 31);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(75, 27);
            this.btn_showAll.TabIndex = 8;
            this.btn_showAll.Text = "All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btn_showByWeek
            // 
            this.btn_showByWeek.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showByWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showByWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showByWeek.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showByWeek.Location = new System.Drawing.Point(186, 31);
            this.btn_showByWeek.Name = "btn_showByWeek";
            this.btn_showByWeek.Size = new System.Drawing.Size(75, 27);
            this.btn_showByWeek.TabIndex = 7;
            this.btn_showByWeek.Text = "Week";
            this.btn_showByWeek.UseVisualStyleBackColor = false;
            this.btn_showByWeek.Click += new System.EventHandler(this.btn_showByWeek_Click);
            // 
            // btn_showByMonth
            // 
            this.btn_showByMonth.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showByMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_showByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_showByMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showByMonth.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showByMonth.Location = new System.Drawing.Point(96, 31);
            this.btn_showByMonth.Name = "btn_showByMonth";
            this.btn_showByMonth.Size = new System.Drawing.Size(75, 27);
            this.btn_showByMonth.TabIndex = 6;
            this.btn_showByMonth.Text = "Month";
            this.btn_showByMonth.UseVisualStyleBackColor = false;
            this.btn_showByMonth.Click += new System.EventHandler(this.btn_showByMonth_Click);
            // 
            // lb_Appointments
            // 
            this.lb_Appointments.AutoSize = true;
            this.lb_Appointments.Location = new System.Drawing.Point(7, 60);
            this.lb_Appointments.Name = "lb_Appointments";
            this.lb_Appointments.Size = new System.Drawing.Size(144, 15);
            this.lb_Appointments.TabIndex = 6;
            this.lb_Appointments.Text = "Appointments Scheduled";
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.AllowUserToAddRows = false;
            this.dgv_Appointments.AllowUserToDeleteRows = false;
            this.dgv_Appointments.AllowUserToResizeColumns = false;
            this.dgv_Appointments.AllowUserToResizeRows = false;
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.Location = new System.Drawing.Point(7, 77);
            this.dgv_Appointments.MultiSelect = false;
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.ReadOnly = true;
            this.dgv_Appointments.RowHeadersVisible = false;
            this.dgv_Appointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Appointments.RowTemplate.Height = 25;
            this.dgv_Appointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Appointments.Size = new System.Drawing.Size(1297, 511);
            this.dgv_Appointments.TabIndex = 3;
            this.dgv_Appointments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Appointments_CellClick);
            // 
            // btn_DelApt
            // 
            this.btn_DelApt.BackColor = System.Drawing.Color.Red;
            this.btn_DelApt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DelApt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DelApt.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_DelApt.Location = new System.Drawing.Point(1221, 594);
            this.btn_DelApt.Name = "btn_DelApt";
            this.btn_DelApt.Size = new System.Drawing.Size(83, 42);
            this.btn_DelApt.TabIndex = 2;
            this.btn_DelApt.Text = "Delete";
            this.btn_DelApt.UseVisualStyleBackColor = false;
            this.btn_DelApt.Click += new System.EventHandler(this.btn_DelApt_Click);
            // 
            // tab_Customers
            // 
            this.tab_Customers.BackColor = System.Drawing.Color.AliceBlue;
            this.tab_Customers.Controls.Add(this.btn_delAddress);
            this.tab_Customers.Controls.Add(this.dgv_addresses);
            this.tab_Customers.Controls.Add(this.label2);
            this.tab_Customers.Controls.Add(this.btn_DelCustomer);
            this.tab_Customers.Controls.Add(this.btn_ModCustomer);
            this.tab_Customers.Controls.Add(this.btn_AddCustomer);
            this.tab_Customers.Controls.Add(this.lb_Customers);
            this.tab_Customers.Controls.Add(this.dgv_Customers);
            this.tab_Customers.Location = new System.Drawing.Point(4, 24);
            this.tab_Customers.Name = "tab_Customers";
            this.tab_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customers.Size = new System.Drawing.Size(1310, 720);
            this.tab_Customers.TabIndex = 2;
            this.tab_Customers.Text = "Customers";
            // 
            // btn_delAddress
            // 
            this.btn_delAddress.BackColor = System.Drawing.Color.Red;
            this.btn_delAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_delAddress.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_delAddress.Location = new System.Drawing.Point(1221, 672);
            this.btn_delAddress.Name = "btn_delAddress";
            this.btn_delAddress.Size = new System.Drawing.Size(83, 42);
            this.btn_delAddress.TabIndex = 17;
            this.btn_delAddress.Text = "Delete";
            this.btn_delAddress.UseVisualStyleBackColor = false;
            this.btn_delAddress.Click += new System.EventHandler(this.btn_delAddress_Click);
            // 
            // dgv_addresses
            // 
            this.dgv_addresses.AllowUserToAddRows = false;
            this.dgv_addresses.AllowUserToDeleteRows = false;
            this.dgv_addresses.AllowUserToResizeColumns = false;
            this.dgv_addresses.AllowUserToResizeRows = false;
            this.dgv_addresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addresses.Location = new System.Drawing.Point(7, 389);
            this.dgv_addresses.MultiSelect = false;
            this.dgv_addresses.Name = "dgv_addresses";
            this.dgv_addresses.ReadOnly = true;
            this.dgv_addresses.RowHeadersVisible = false;
            this.dgv_addresses.RowTemplate.Height = 25;
            this.dgv_addresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_addresses.Size = new System.Drawing.Size(1297, 277);
            this.dgv_addresses.TabIndex = 14;
            this.dgv_addresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addresses_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer Address";
            // 
            // btn_DelCustomer
            // 
            this.btn_DelCustomer.BackColor = System.Drawing.Color.Red;
            this.btn_DelCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DelCustomer.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_DelCustomer.Location = new System.Drawing.Point(1224, 304);
            this.btn_DelCustomer.Name = "btn_DelCustomer";
            this.btn_DelCustomer.Size = new System.Drawing.Size(83, 42);
            this.btn_DelCustomer.TabIndex = 12;
            this.btn_DelCustomer.Text = "Delete";
            this.btn_DelCustomer.UseVisualStyleBackColor = false;
            this.btn_DelCustomer.Click += new System.EventHandler(this.btn_DelCustomer_Click);
            // 
            // btn_ModCustomer
            // 
            this.btn_ModCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ModCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ModCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ModCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_ModCustomer.Location = new System.Drawing.Point(1135, 304);
            this.btn_ModCustomer.Name = "btn_ModCustomer";
            this.btn_ModCustomer.Size = new System.Drawing.Size(83, 42);
            this.btn_ModCustomer.TabIndex = 11;
            this.btn_ModCustomer.Text = "Modify";
            this.btn_ModCustomer.UseVisualStyleBackColor = false;
            this.btn_ModCustomer.Click += new System.EventHandler(this.btn_ModCustomer_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AddCustomer.Location = new System.Drawing.Point(1046, 304);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(83, 42);
            this.btn_AddCustomer.TabIndex = 10;
            this.btn_AddCustomer.Text = "Add New";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // lb_Customers
            // 
            this.lb_Customers.AutoSize = true;
            this.lb_Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Customers.Location = new System.Drawing.Point(7, 3);
            this.lb_Customers.Name = "lb_Customers";
            this.lb_Customers.Size = new System.Drawing.Size(71, 16);
            this.lb_Customers.TabIndex = 3;
            this.lb_Customers.Text = "Customers";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToAddRows = false;
            this.dgv_Customers.AllowUserToDeleteRows = false;
            this.dgv_Customers.AllowUserToResizeColumns = false;
            this.dgv_Customers.AllowUserToResizeRows = false;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Location = new System.Drawing.Point(7, 21);
            this.dgv_Customers.MultiSelect = false;
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.ReadOnly = true;
            this.dgv_Customers.RowHeadersVisible = false;
            this.dgv_Customers.RowTemplate.Height = 25;
            this.dgv_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Customers.Size = new System.Drawing.Size(1297, 277);
            this.dgv_Customers.TabIndex = 2;
            this.dgv_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customers_CellClick);
            // 
            // tab_Tools
            // 
            this.tab_Tools.BackColor = System.Drawing.Color.AliceBlue;
            this.tab_Tools.Controls.Add(this.label7);
            this.tab_Tools.Controls.Add(this.label3);
            this.tab_Tools.Controls.Add(this.tb_loginReport);
            this.tab_Tools.Controls.Add(this.lb_Users);
            this.tab_Tools.Controls.Add(this.dgv_Users);
            this.tab_Tools.Controls.Add(this.groupBox2);
            this.tab_Tools.Controls.Add(this.gb_Reports);
            this.tab_Tools.Location = new System.Drawing.Point(4, 24);
            this.tab_Tools.Name = "tab_Tools";
            this.tab_Tools.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Tools.Size = new System.Drawing.Size(1310, 720);
            this.tab_Tools.TabIndex = 3;
            this.tab_Tools.Text = "Tools";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(938, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Note: Log file saved to c:\\Downloads\\Reports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(872, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Sign In Log ";
            // 
            // tb_loginReport
            // 
            this.tb_loginReport.Location = new System.Drawing.Point(872, 45);
            this.tb_loginReport.Multiline = true;
            this.tb_loginReport.Name = "tb_loginReport";
            this.tb_loginReport.ReadOnly = true;
            this.tb_loginReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_loginReport.Size = new System.Drawing.Size(407, 326);
            this.tb_loginReport.TabIndex = 7;
            // 
            // lb_Users
            // 
            this.lb_Users.AutoSize = true;
            this.lb_Users.Location = new System.Drawing.Point(277, 24);
            this.lb_Users.Name = "lb_Users";
            this.lb_Users.Size = new System.Drawing.Size(112, 15);
            this.lb_Users.TabIndex = 6;
            this.lb_Users.Text = "Users / Consultants";
            // 
            // dgv_Users
            // 
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Location = new System.Drawing.Point(277, 45);
            this.dgv_Users.MultiSelect = false;
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.RowHeadersVisible = false;
            this.dgv_Users.RowTemplate.Height = 25;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(589, 326);
            this.dgv_Users.TabIndex = 5;
            this.dgv_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.btn_delUser);
            this.groupBox2.Controls.Add(this.btn_modUser);
            this.groupBox2.Controls.Add(this.btn_AddUser);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(7, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 326);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User / Consultant Management";
            // 
            // btn_delUser
            // 
            this.btn_delUser.Location = new System.Drawing.Point(55, 211);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(103, 41);
            this.btn_delUser.TabIndex = 2;
            this.btn_delUser.Text = "Delete User";
            this.btn_delUser.UseVisualStyleBackColor = true;
            this.btn_delUser.Click += new System.EventHandler(this.delUser_Click);
            // 
            // btn_modUser
            // 
            this.btn_modUser.Location = new System.Drawing.Point(55, 135);
            this.btn_modUser.Name = "btn_modUser";
            this.btn_modUser.Size = new System.Drawing.Size(103, 41);
            this.btn_modUser.TabIndex = 1;
            this.btn_modUser.Text = "Modify User";
            this.btn_modUser.UseVisualStyleBackColor = true;
            this.btn_modUser.Click += new System.EventHandler(this.btn_modUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(55, 60);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(103, 41);
            this.btn_AddUser.TabIndex = 0;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // gb_Reports
            // 
            this.gb_Reports.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_Reports.Controls.Add(this.lb_aptsByCity);
            this.gb_Reports.Controls.Add(this.btn_aptsByCustomer);
            this.gb_Reports.Controls.Add(this.label6);
            this.gb_Reports.Controls.Add(this.btn_loginLogs);
            this.gb_Reports.Controls.Add(this.label5);
            this.gb_Reports.Controls.Add(this.label4);
            this.gb_Reports.Controls.Add(this.btn_aptTypesMonth);
            this.gb_Reports.Controls.Add(this.btn_sheduleByUser);
            this.gb_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Reports.Location = new System.Drawing.Point(277, 388);
            this.gb_Reports.Name = "gb_Reports";
            this.gb_Reports.Size = new System.Drawing.Size(1003, 187);
            this.gb_Reports.TabIndex = 3;
            this.gb_Reports.TabStop = false;
            this.gb_Reports.Text = "Reports";
            // 
            // lb_aptsByCity
            // 
            this.lb_aptsByCity.AutoSize = true;
            this.lb_aptsByCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_aptsByCity.Location = new System.Drawing.Point(279, 51);
            this.lb_aptsByCity.Name = "lb_aptsByCity";
            this.lb_aptsByCity.Size = new System.Drawing.Size(193, 20);
            this.lb_aptsByCity.TabIndex = 8;
            this.lb_aptsByCity.Text = "Appointment by Customer";
            // 
            // btn_aptsByCustomer
            // 
            this.btn_aptsByCustomer.Location = new System.Drawing.Point(321, 85);
            this.btn_aptsByCustomer.Name = "btn_aptsByCustomer";
            this.btn_aptsByCustomer.Size = new System.Drawing.Size(103, 41);
            this.btn_aptsByCustomer.TabIndex = 7;
            this.btn_aptsByCustomer.Text = "Report";
            this.btn_aptsByCustomer.UseVisualStyleBackColor = true;
            this.btn_aptsByCustomer.Click += new System.EventHandler(this.btn_aptsByCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(787, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Login Report by User";
            // 
            // btn_loginLogs
            // 
            this.btn_loginLogs.Location = new System.Drawing.Point(829, 85);
            this.btn_loginLogs.Name = "btn_loginLogs";
            this.btn_loginLogs.Size = new System.Drawing.Size(103, 41);
            this.btn_loginLogs.TabIndex = 5;
            this.btn_loginLogs.Text = "Report";
            this.btn_loginLogs.UseVisualStyleBackColor = true;
            this.btn_loginLogs.Click += new System.EventHandler(this.btn_loginLogs_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(524, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Schedule by Consultant (All)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Types by Month";
            // 
            // btn_aptTypesMonth
            // 
            this.btn_aptTypesMonth.Location = new System.Drawing.Point(67, 85);
            this.btn_aptTypesMonth.Name = "btn_aptTypesMonth";
            this.btn_aptTypesMonth.Size = new System.Drawing.Size(103, 41);
            this.btn_aptTypesMonth.TabIndex = 1;
            this.btn_aptTypesMonth.Text = "Report";
            this.btn_aptTypesMonth.UseVisualStyleBackColor = true;
            this.btn_aptTypesMonth.Click += new System.EventHandler(this.btn_aptTypesMonth_Click);
            // 
            // btn_sheduleByUser
            // 
            this.btn_sheduleByUser.Location = new System.Drawing.Point(575, 85);
            this.btn_sheduleByUser.Name = "btn_sheduleByUser";
            this.btn_sheduleByUser.Size = new System.Drawing.Size(103, 41);
            this.btn_sheduleByUser.TabIndex = 2;
            this.btn_sheduleByUser.Text = "Report";
            this.btn_sheduleByUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment Scheduler";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.lb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_user.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_user.Location = new System.Drawing.Point(1114, 67);
            this.lb_user.Name = "lb_user";
            this.lb_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_user.Size = new System.Drawing.Size(92, 16);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "logged in user";
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
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.dashTabControl.ResumeLayout(false);
            this.tab_Appointments.ResumeLayout(false);
            this.tab_Appointments.PerformLayout();
            this.gb_filterAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            this.tab_Customers.ResumeLayout(false);
            this.tab_Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.tab_Tools.ResumeLayout(false);
            this.tab_Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gb_Reports.ResumeLayout(false);
            this.gb_Reports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dashTabControl;
        private System.Windows.Forms.TabPage tab_Appointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_Customers;
        private System.Windows.Forms.Label lb_Customers;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Button btn_DelApt;
        private System.Windows.Forms.Label lb_Appointments;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.GroupBox gb_addAptForm;
        private System.Windows.Forms.TextBox tb_aptDesc;
        private System.Windows.Forms.TextBox tb_aptTitle;
        private System.Windows.Forms.TextBox tb_aptID;
        private System.Windows.Forms.GroupBox gb_filterAppointments;
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
        private System.Windows.Forms.Label lb_aptType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_aptLocation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_aptURL;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TabPage tab_Tools;
        private System.Windows.Forms.Button btn_aptTypesMonth;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.GroupBox gb_Reports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_loginLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delUser;
        private System.Windows.Forms.Button btn_modUser;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Label lb_Users;
        private System.Windows.Forms.Button btn_ModAppt;
        private System.Windows.Forms.Button btn_DelCustomer;
        private System.Windows.Forms.Button btn_ModCustomer;
        private System.Windows.Forms.Button btn_AddCustomer;
        public System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.Button btn_delAddress;
        private System.Windows.Forms.DataGridView dgv_addresses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_loginReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sheduleByUser;
        private System.Windows.Forms.Label lb_aptsByCity;
        private System.Windows.Forms.Button btn_aptsByCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_currentView;
        private System.Windows.Forms.TextBox tb_searchByDoc;
        private System.Windows.Forms.TextBox tb_searchByPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_search;
    }
}
