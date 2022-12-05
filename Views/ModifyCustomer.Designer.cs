
namespace AppointmentScheduler_C969.Views
{
    partial class ModifyCustomer
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
            this.gb_ModCustomer = new System.Windows.Forms.GroupBox();
            this.ll_modCustCancel = new System.Windows.Forms.LinkLabel();
            this.btn_editModCust = new System.Windows.Forms.Button();
            this.gb_updateName = new System.Windows.Forms.GroupBox();
            this.chk_ActiveUser = new System.Windows.Forms.CheckBox();
            this.btn_updateName = new System.Windows.Forms.Button();
            this.tb_custName = new System.Windows.Forms.TextBox();
            this.lb_custName = new System.Windows.Forms.Label();
            this.gb_updateAddr = new System.Windows.Forms.GroupBox();
            this.tb_countryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_updateAddr = new System.Windows.Forms.Button();
            this.btn_modCustomerAddCity = new System.Windows.Forms.Button();
            this.cb_modCustCityList = new System.Windows.Forms.ComboBox();
            this.tb_phoneNum = new System.Windows.Forms.TextBox();
            this.tb_postCode = new System.Windows.Forms.TextBox();
            this.tb_custAddr2 = new System.Windows.Forms.TextBox();
            this.tb_custAddr1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_ModCustomer.SuspendLayout();
            this.gb_updateName.SuspendLayout();
            this.gb_updateAddr.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ModCustomer
            // 
            this.gb_ModCustomer.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_ModCustomer.Controls.Add(this.ll_modCustCancel);
            this.gb_ModCustomer.Controls.Add(this.btn_editModCust);
            this.gb_ModCustomer.Controls.Add(this.gb_updateName);
            this.gb_ModCustomer.Controls.Add(this.gb_updateAddr);
            this.gb_ModCustomer.Location = new System.Drawing.Point(12, 12);
            this.gb_ModCustomer.Name = "gb_ModCustomer";
            this.gb_ModCustomer.Size = new System.Drawing.Size(411, 629);
            this.gb_ModCustomer.TabIndex = 0;
            this.gb_ModCustomer.TabStop = false;
            this.gb_ModCustomer.Text = "Modify Customer";
            // 
            // ll_modCustCancel
            // 
            this.ll_modCustCancel.AutoSize = true;
            this.ll_modCustCancel.BackColor = System.Drawing.SystemColors.Control;
            this.ll_modCustCancel.DisabledLinkColor = System.Drawing.Color.Red;
            this.ll_modCustCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ll_modCustCancel.LinkColor = System.Drawing.Color.Red;
            this.ll_modCustCancel.Location = new System.Drawing.Point(341, 605);
            this.ll_modCustCancel.Name = "ll_modCustCancel";
            this.ll_modCustCancel.Size = new System.Drawing.Size(64, 18);
            this.ll_modCustCancel.TabIndex = 39;
            this.ll_modCustCancel.TabStop = true;
            this.ll_modCustCancel.Text = "Cancel";
            this.ll_modCustCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_modCustCancel_LinkClicked);
            // 
            // btn_editModCust
            // 
            this.btn_editModCust.BackColor = System.Drawing.Color.LightBlue;
            this.btn_editModCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editModCust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_editModCust.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_editModCust.Location = new System.Drawing.Point(6, 586);
            this.btn_editModCust.Name = "btn_editModCust";
            this.btn_editModCust.Size = new System.Drawing.Size(84, 37);
            this.btn_editModCust.TabIndex = 4;
            this.btn_editModCust.Text = "Edit";
            this.btn_editModCust.UseVisualStyleBackColor = false;
            this.btn_editModCust.Click += new System.EventHandler(this.btn_editModCust_Click);
            // 
            // gb_updateName
            // 
            this.gb_updateName.BackColor = System.Drawing.Color.Transparent;
            this.gb_updateName.Controls.Add(this.chk_ActiveUser);
            this.gb_updateName.Controls.Add(this.btn_updateName);
            this.gb_updateName.Controls.Add(this.tb_custName);
            this.gb_updateName.Controls.Add(this.lb_custName);
            this.gb_updateName.Location = new System.Drawing.Point(6, 22);
            this.gb_updateName.Name = "gb_updateName";
            this.gb_updateName.Size = new System.Drawing.Size(399, 100);
            this.gb_updateName.TabIndex = 3;
            this.gb_updateName.TabStop = false;
            this.gb_updateName.Text = "Update Name";
            // 
            // chk_ActiveUser
            // 
            this.chk_ActiveUser.AutoSize = true;
            this.chk_ActiveUser.Enabled = false;
            this.chk_ActiveUser.Location = new System.Drawing.Point(61, 66);
            this.chk_ActiveUser.Name = "chk_ActiveUser";
            this.chk_ActiveUser.Size = new System.Drawing.Size(59, 19);
            this.chk_ActiveUser.TabIndex = 2;
            this.chk_ActiveUser.Text = "Active";
            this.chk_ActiveUser.UseVisualStyleBackColor = true;
            this.chk_ActiveUser.CheckStateChanged += new System.EventHandler(this.chk_ActiveUser_CheckStateChanged);
            // 
            // btn_updateName
            // 
            this.btn_updateName.BackColor = System.Drawing.Color.LightBlue;
            this.btn_updateName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_updateName.Location = new System.Drawing.Point(318, 66);
            this.btn_updateName.Name = "btn_updateName";
            this.btn_updateName.Size = new System.Drawing.Size(75, 28);
            this.btn_updateName.TabIndex = 3;
            this.btn_updateName.Text = "Update";
            this.btn_updateName.UseVisualStyleBackColor = false;
            this.btn_updateName.Visible = false;
            this.btn_updateName.Click += new System.EventHandler(this.btn_updateName_Click);
            // 
            // tb_custName
            // 
            this.tb_custName.Enabled = false;
            this.tb_custName.Location = new System.Drawing.Point(61, 28);
            this.tb_custName.Name = "tb_custName";
            this.tb_custName.Size = new System.Drawing.Size(276, 23);
            this.tb_custName.TabIndex = 1;
            // 
            // lb_custName
            // 
            this.lb_custName.AutoSize = true;
            this.lb_custName.Location = new System.Drawing.Point(6, 32);
            this.lb_custName.Name = "lb_custName";
            this.lb_custName.Size = new System.Drawing.Size(39, 15);
            this.lb_custName.TabIndex = 0;
            this.lb_custName.Text = "Name";
            // 
            // gb_updateAddr
            // 
            this.gb_updateAddr.BackColor = System.Drawing.Color.Transparent;
            this.gb_updateAddr.Controls.Add(this.tb_countryName);
            this.gb_updateAddr.Controls.Add(this.label7);
            this.gb_updateAddr.Controls.Add(this.btn_updateAddr);
            this.gb_updateAddr.Controls.Add(this.btn_modCustomerAddCity);
            this.gb_updateAddr.Controls.Add(this.cb_modCustCityList);
            this.gb_updateAddr.Controls.Add(this.tb_phoneNum);
            this.gb_updateAddr.Controls.Add(this.tb_postCode);
            this.gb_updateAddr.Controls.Add(this.tb_custAddr2);
            this.gb_updateAddr.Controls.Add(this.tb_custAddr1);
            this.gb_updateAddr.Controls.Add(this.label6);
            this.gb_updateAddr.Controls.Add(this.label5);
            this.gb_updateAddr.Controls.Add(this.label4);
            this.gb_updateAddr.Controls.Add(this.label3);
            this.gb_updateAddr.Controls.Add(this.label2);
            this.gb_updateAddr.Location = new System.Drawing.Point(6, 153);
            this.gb_updateAddr.Name = "gb_updateAddr";
            this.gb_updateAddr.Size = new System.Drawing.Size(399, 403);
            this.gb_updateAddr.TabIndex = 2;
            this.gb_updateAddr.TabStop = false;
            this.gb_updateAddr.Text = "Update Address";
            // 
            // tb_countryName
            // 
            this.tb_countryName.Enabled = false;
            this.tb_countryName.Location = new System.Drawing.Point(95, 211);
            this.tb_countryName.Name = "tb_countryName";
            this.tb_countryName.ReadOnly = true;
            this.tb_countryName.Size = new System.Drawing.Size(100, 23);
            this.tb_countryName.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Country";
            // 
            // btn_updateAddr
            // 
            this.btn_updateAddr.BackColor = System.Drawing.Color.LightBlue;
            this.btn_updateAddr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateAddr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_updateAddr.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_updateAddr.Location = new System.Drawing.Point(318, 369);
            this.btn_updateAddr.Name = "btn_updateAddr";
            this.btn_updateAddr.Size = new System.Drawing.Size(75, 28);
            this.btn_updateAddr.TabIndex = 10;
            this.btn_updateAddr.Text = "Update";
            this.btn_updateAddr.UseVisualStyleBackColor = false;
            this.btn_updateAddr.Visible = false;
            this.btn_updateAddr.Click += new System.EventHandler(this.btn_updateAddr_Click);
            // 
            // btn_modCustomerAddCity
            // 
            this.btn_modCustomerAddCity.BackColor = System.Drawing.Color.LightBlue;
            this.btn_modCustomerAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modCustomerAddCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modCustomerAddCity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_modCustomerAddCity.Location = new System.Drawing.Point(284, 154);
            this.btn_modCustomerAddCity.Name = "btn_modCustomerAddCity";
            this.btn_modCustomerAddCity.Size = new System.Drawing.Size(53, 23);
            this.btn_modCustomerAddCity.TabIndex = 7;
            this.btn_modCustomerAddCity.Text = "Add";
            this.btn_modCustomerAddCity.UseVisualStyleBackColor = false;
            this.btn_modCustomerAddCity.Visible = false;
            this.btn_modCustomerAddCity.Click += new System.EventHandler(this.btn_modCustomerAddCity_Click);
            // 
            // cb_modCustCityList
            // 
            this.cb_modCustCityList.Enabled = false;
            this.cb_modCustCityList.FormattingEnabled = true;
            this.cb_modCustCityList.ItemHeight = 15;
            this.cb_modCustCityList.Location = new System.Drawing.Point(95, 154);
            this.cb_modCustCityList.Name = "cb_modCustCityList";
            this.cb_modCustCityList.Size = new System.Drawing.Size(165, 23);
            this.cb_modCustCityList.TabIndex = 11;
            this.cb_modCustCityList.SelectedIndexChanged += new System.EventHandler(this.cb_modCustCityList_SelectedIndexChanged);
            // 
            // tb_phoneNum
            // 
            this.tb_phoneNum.Enabled = false;
            this.tb_phoneNum.Location = new System.Drawing.Point(95, 325);
            this.tb_phoneNum.Name = "tb_phoneNum";
            this.tb_phoneNum.Size = new System.Drawing.Size(165, 23);
            this.tb_phoneNum.TabIndex = 9;
            // 
            // tb_postCode
            // 
            this.tb_postCode.Enabled = false;
            this.tb_postCode.Location = new System.Drawing.Point(95, 268);
            this.tb_postCode.Name = "tb_postCode";
            this.tb_postCode.Size = new System.Drawing.Size(100, 23);
            this.tb_postCode.TabIndex = 8;
            // 
            // tb_custAddr2
            // 
            this.tb_custAddr2.Enabled = false;
            this.tb_custAddr2.Location = new System.Drawing.Point(95, 97);
            this.tb_custAddr2.Name = "tb_custAddr2";
            this.tb_custAddr2.Size = new System.Drawing.Size(242, 23);
            this.tb_custAddr2.TabIndex = 5;
            // 
            // tb_custAddr1
            // 
            this.tb_custAddr1.Enabled = false;
            this.tb_custAddr1.Location = new System.Drawing.Point(95, 40);
            this.tb_custAddr1.Name = "tb_custAddr1";
            this.tb_custAddr1.Size = new System.Drawing.Size(242, 23);
            this.tb_custAddr1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // ModifyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 650);
            this.Controls.Add(this.gb_ModCustomer);
            this.Name = "ModifyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyCustomer";
            this.gb_ModCustomer.ResumeLayout(false);
            this.gb_ModCustomer.PerformLayout();
            this.gb_updateName.ResumeLayout(false);
            this.gb_updateName.PerformLayout();
            this.gb_updateAddr.ResumeLayout(false);
            this.gb_updateAddr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ModCustomer;
        private System.Windows.Forms.GroupBox gb_updateName;
        private System.Windows.Forms.TextBox tb_custName;
        private System.Windows.Forms.Label lb_custName;
        private System.Windows.Forms.GroupBox gb_updateAddr;
        private System.Windows.Forms.Button btn_modCustomerAddCity;
        private System.Windows.Forms.ComboBox cb_modCustCityList;
        private System.Windows.Forms.TextBox tb_phoneNum;
        private System.Windows.Forms.TextBox tb_postCode;
        private System.Windows.Forms.TextBox tb_custAddr2;
        private System.Windows.Forms.TextBox tb_custAddr1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_countryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_editModCust;
        private System.Windows.Forms.LinkLabel ll_modCustCancel;
        private System.Windows.Forms.Button tb_updateName;
        private System.Windows.Forms.Button btn_updateName;
        private System.Windows.Forms.Button btn_updateAddr;
        private System.Windows.Forms.CheckBox chk_ActiveUser;
    }
}