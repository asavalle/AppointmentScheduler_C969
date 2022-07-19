
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gb_addAptForm = new System.Windows.Forms.GroupBox();
            this.lb_aptType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AddApt = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb_endTime = new System.Windows.Forms.Label();
            this.lb_startTime = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_aptDate = new System.Windows.Forms.Label();
            this.lb_aptDesc = new System.Windows.Forms.Label();
            this.lb_aptTitle = new System.Windows.Forms.Label();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_aptID = new System.Windows.Forms.Label();
            this.tb_aptDesc = new System.Windows.Forms.TextBox();
            this.tb_aptTitle = new System.Windows.Forms.TextBox();
            this.tb_aptID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_showByWeek = new System.Windows.Forms.Button();
            this.btn_showByMonth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_DelApt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_DelCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_aptLocation = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_aptURL = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dashTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_addAptForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dashTabControl
            // 
            this.dashTabControl.Controls.Add(this.tabPage1);
            this.dashTabControl.Controls.Add(this.tabPage3);
            this.dashTabControl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashTabControl.Location = new System.Drawing.Point(2, 67);
            this.dashTabControl.Name = "dashTabControl";
            this.dashTabControl.SelectedIndex = 0;
            this.dashTabControl.Size = new System.Drawing.Size(1318, 748);
            this.dashTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gb_addAptForm);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.btn_DelApt);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1310, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gb_addAptForm
            // 
            this.gb_addAptForm.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_addAptForm.Controls.Add(this.lb_aptURL);
            this.gb_addAptForm.Controls.Add(this.textBox3);
            this.gb_addAptForm.Controls.Add(this.lb_aptLocation);
            this.gb_addAptForm.Controls.Add(this.textBox2);
            this.gb_addAptForm.Controls.Add(this.lb_aptType);
            this.gb_addAptForm.Controls.Add(this.textBox1);
            this.gb_addAptForm.Controls.Add(this.button1);
            this.gb_addAptForm.Controls.Add(this.btn_AddApt);
            this.gb_addAptForm.Controls.Add(this.comboBox2);
            this.gb_addAptForm.Controls.Add(this.lb_endTime);
            this.gb_addAptForm.Controls.Add(this.lb_startTime);
            this.gb_addAptForm.Controls.Add(this.comboBox1);
            this.gb_addAptForm.Controls.Add(this.dateTimePicker1);
            this.gb_addAptForm.Controls.Add(this.lb_aptDate);
            this.gb_addAptForm.Controls.Add(this.lb_aptDesc);
            this.gb_addAptForm.Controls.Add(this.lb_aptTitle);
            this.gb_addAptForm.Controls.Add(this.cb_customer);
            this.gb_addAptForm.Controls.Add(this.label5);
            this.gb_addAptForm.Controls.Add(this.lb_aptID);
            this.gb_addAptForm.Controls.Add(this.tb_aptDesc);
            this.gb_addAptForm.Controls.Add(this.tb_aptTitle);
            this.gb_addAptForm.Controls.Add(this.tb_aptID);
            this.gb_addAptForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_addAptForm.Location = new System.Drawing.Point(893, 7);
            this.gb_addAptForm.Name = "gb_addAptForm";
            this.gb_addAptForm.Size = new System.Drawing.Size(411, 629);
            this.gb_addAptForm.TabIndex = 9;
            this.gb_addAptForm.TabStop = false;
            this.gb_addAptForm.Text = "Add New Appointment";
            // 
            // lb_aptType
            // 
            this.lb_aptType.AutoSize = true;
            this.lb_aptType.Location = new System.Drawing.Point(26, 152);
            this.lb_aptType.Name = "lb_aptType";
            this.lb_aptType.Size = new System.Drawing.Size(37, 14);
            this.lb_aptType.TabIndex = 20;
            this.lb_aptType.Text = "Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 21);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(330, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_AddApt
            // 
            this.btn_AddApt.BackColor = System.Drawing.Color.LightBlue;
            this.btn_AddApt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddApt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AddApt.Location = new System.Drawing.Point(229, 581);
            this.btn_AddApt.Name = "btn_AddApt";
            this.btn_AddApt.Size = new System.Drawing.Size(84, 37);
            this.btn_AddApt.TabIndex = 17;
            this.btn_AddApt.Text = "Add";
            this.btn_AddApt.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(149, 360);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 22);
            this.comboBox2.TabIndex = 16;
            // 
            // lb_endTime
            // 
            this.lb_endTime.AutoSize = true;
            this.lb_endTime.Location = new System.Drawing.Point(149, 344);
            this.lb_endTime.Name = "lb_endTime";
            this.lb_endTime.Size = new System.Drawing.Size(62, 14);
            this.lb_endTime.TabIndex = 15;
            this.lb_endTime.Text = "End Time";
            // 
            // lb_startTime
            // 
            this.lb_startTime.AutoSize = true;
            this.lb_startTime.Location = new System.Drawing.Point(26, 343);
            this.lb_startTime.Name = "lb_startTime";
            this.lb_startTime.Size = new System.Drawing.Size(67, 14);
            this.lb_startTime.TabIndex = 14;
            this.lb_startTime.Text = "Start Time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 22);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 415);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lb_aptDate
            // 
            this.lb_aptDate.AutoSize = true;
            this.lb_aptDate.Location = new System.Drawing.Point(26, 398);
            this.lb_aptDate.Name = "lb_aptDate";
            this.lb_aptDate.Size = new System.Drawing.Size(65, 14);
            this.lb_aptDate.TabIndex = 9;
            this.lb_aptDate.Text = "Start Date";
            // 
            // lb_aptDesc
            // 
            this.lb_aptDesc.AutoSize = true;
            this.lb_aptDesc.Location = new System.Drawing.Point(26, 198);
            this.lb_aptDesc.Name = "lb_aptDesc";
            this.lb_aptDesc.Size = new System.Drawing.Size(74, 14);
            this.lb_aptDesc.TabIndex = 8;
            this.lb_aptDesc.Text = "Description";
            // 
            // lb_aptTitle
            // 
            this.lb_aptTitle.AutoSize = true;
            this.lb_aptTitle.Location = new System.Drawing.Point(26, 102);
            this.lb_aptTitle.Name = "lb_aptTitle";
            this.lb_aptTitle.Size = new System.Drawing.Size(32, 14);
            this.lb_aptTitle.TabIndex = 7;
            this.lb_aptTitle.Text = "Title";
            // 
            // cb_customer
            // 
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(105, 70);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(270, 22);
            this.cb_customer.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer";
            // 
            // lb_aptID
            // 
            this.lb_aptID.AutoSize = true;
            this.lb_aptID.Location = new System.Drawing.Point(26, 49);
            this.lb_aptID.Name = "lb_aptID";
            this.lb_aptID.Size = new System.Drawing.Size(48, 14);
            this.lb_aptID.TabIndex = 4;
            this.lb_aptID.Text = "Apt. ID";
            // 
            // tb_aptDesc
            // 
            this.tb_aptDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_aptDesc.Location = new System.Drawing.Point(26, 215);
            this.tb_aptDesc.MaxLength = 250;
            this.tb_aptDesc.Multiline = true;
            this.tb_aptDesc.Name = "tb_aptDesc";
            this.tb_aptDesc.Size = new System.Drawing.Size(349, 110);
            this.tb_aptDesc.TabIndex = 2;
            // 
            // tb_aptTitle
            // 
            this.tb_aptTitle.Location = new System.Drawing.Point(26, 119);
            this.tb_aptTitle.Name = "tb_aptTitle";
            this.tb_aptTitle.Size = new System.Drawing.Size(349, 21);
            this.tb_aptTitle.TabIndex = 1;
            // 
            // tb_aptID
            // 
            this.tb_aptID.Location = new System.Drawing.Point(26, 70);
            this.tb_aptID.Name = "tb_aptID";
            this.tb_aptID.Size = new System.Drawing.Size(51, 21);
            this.tb_aptID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btn_showAll);
            this.groupBox1.Controls.Add(this.btn_showByWeek);
            this.groupBox1.Controls.Add(this.btn_showByMonth);
            this.groupBox1.Location = new System.Drawing.Point(590, 7);
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
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Appointments Scheduled";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 77);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(840, 511);
            this.dataGridView2.TabIndex = 3;
            // 
            // btn_DelApt
            // 
            this.btn_DelApt.BackColor = System.Drawing.Color.Crimson;
            this.btn_DelApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DelApt.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_DelApt.Location = new System.Drawing.Point(776, 594);
            this.btn_DelApt.Name = "btn_DelApt";
            this.btn_DelApt.Size = new System.Drawing.Size(83, 42);
            this.btn_DelApt.TabIndex = 2;
            this.btn_DelApt.Text = "Delete";
            this.btn_DelApt.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btn_DelCustomer);
            this.tabPage3.Controls.Add(this.btn_AddCustomer);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1310, 721);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customers";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1249, 511);
            this.dataGridView1.TabIndex = 2;
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
            this.lb_user.Location = new System.Drawing.Point(1235, 49);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(82, 15);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "logged in user";
            // 
            // lb_aptLocation
            // 
            this.lb_aptLocation.AutoSize = true;
            this.lb_aptLocation.Location = new System.Drawing.Point(26, 449);
            this.lb_aptLocation.Name = "lb_aptLocation";
            this.lb_aptLocation.Size = new System.Drawing.Size(56, 14);
            this.lb_aptLocation.TabIndex = 22;
            this.lb_aptLocation.Text = "Location";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 466);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(349, 21);
            this.textBox2.TabIndex = 21;
            // 
            // lb_aptURL
            // 
            this.lb_aptURL.AutoSize = true;
            this.lb_aptURL.Location = new System.Drawing.Point(26, 494);
            this.lb_aptURL.Name = "lb_aptURL";
            this.lb_aptURL.Size = new System.Drawing.Size(32, 14);
            this.lb_aptURL.TabIndex = 24;
            this.lb_aptURL.Text = "URL";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 511);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(349, 21);
            this.textBox3.TabIndex = 23;
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
            this.Text = "Dashboard";
            this.dashTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gb_addAptForm.ResumeLayout(false);
            this.gb_addAptForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl dashTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_DelCustomer;
        private System.Windows.Forms.Button btn_DelApt;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.Label lb_user;
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
    }
}