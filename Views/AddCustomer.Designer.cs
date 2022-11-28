
namespace AppointmentScheduler_C969.Views
{
    partial class AddCustomer
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
            this.gb_addCustomerForm = new System.Windows.Forms.GroupBox();
            this.tb_countryName = new System.Windows.Forms.TextBox();
            this.btn_addCity = new System.Windows.Forms.Button();
            this.cb_citiesList = new System.Windows.Forms.ComboBox();
            this.cb_newActiveCust = new System.Windows.Forms.CheckBox();
            this.linkLabel_cancel = new System.Windows.Forms.LinkLabel();
            this.btn_CreateCustomer = new System.Windows.Forms.Button();
            this.tb_newCustPhone = new System.Windows.Forms.TextBox();
            this.tb_newCustZip = new System.Windows.Forms.TextBox();
            this.tb_newCustAddress2 = new System.Windows.Forms.TextBox();
            this.tb_newCustAddress = new System.Windows.Forms.TextBox();
            this.tb_newCustName = new System.Windows.Forms.TextBox();
            this.lbl_newCustPhone = new System.Windows.Forms.Label();
            this.lbl_newCustAdd2 = new System.Windows.Forms.Label();
            this.lbl_newCustCountry = new System.Windows.Forms.Label();
            this.lbl_newCustZip = new System.Windows.Forms.Label();
            this.lbl_newCustCity = new System.Windows.Forms.Label();
            this.lbl_newCustAddress = new System.Windows.Forms.Label();
            this.lbl_active = new System.Windows.Forms.Label();
            this.lbl_custName = new System.Windows.Forms.Label();
            this.gb_addCustomerForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_addCustomerForm
            // 
            this.gb_addCustomerForm.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_addCustomerForm.Controls.Add(this.tb_countryName);
            this.gb_addCustomerForm.Controls.Add(this.btn_addCity);
            this.gb_addCustomerForm.Controls.Add(this.cb_citiesList);
            this.gb_addCustomerForm.Controls.Add(this.cb_newActiveCust);
            this.gb_addCustomerForm.Controls.Add(this.linkLabel_cancel);
            this.gb_addCustomerForm.Controls.Add(this.btn_CreateCustomer);
            this.gb_addCustomerForm.Controls.Add(this.tb_newCustPhone);
            this.gb_addCustomerForm.Controls.Add(this.tb_newCustZip);
            this.gb_addCustomerForm.Controls.Add(this.tb_newCustAddress2);
            this.gb_addCustomerForm.Controls.Add(this.tb_newCustAddress);
            this.gb_addCustomerForm.Controls.Add(this.tb_newCustName);
            this.gb_addCustomerForm.Controls.Add(this.lbl_newCustPhone);
            this.gb_addCustomerForm.Controls.Add(this.lbl_newCustAdd2);
            this.gb_addCustomerForm.Controls.Add(this.lbl_newCustCountry);
            this.gb_addCustomerForm.Controls.Add(this.lbl_newCustZip);
            this.gb_addCustomerForm.Controls.Add(this.lbl_newCustCity);
            this.gb_addCustomerForm.Controls.Add(this.lbl_newCustAddress);
            this.gb_addCustomerForm.Controls.Add(this.lbl_active);
            this.gb_addCustomerForm.Controls.Add(this.lbl_custName);
            this.gb_addCustomerForm.Location = new System.Drawing.Point(12, 12);
            this.gb_addCustomerForm.Name = "gb_addCustomerForm";
            this.gb_addCustomerForm.Size = new System.Drawing.Size(411, 629);
            this.gb_addCustomerForm.TabIndex = 0;
            this.gb_addCustomerForm.TabStop = false;
            this.gb_addCustomerForm.Text = "Add Customer";
            // 
            // tb_countryName
            // 
            this.tb_countryName.Location = new System.Drawing.Point(149, 348);
            this.tb_countryName.Name = "tb_countryName";
            this.tb_countryName.ReadOnly = true;
            this.tb_countryName.Size = new System.Drawing.Size(164, 23);
            this.tb_countryName.TabIndex = 22;
            // 
            // btn_addCity
            // 
            this.btn_addCity.BackColor = System.Drawing.Color.Lavender;
            this.btn_addCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCity.Location = new System.Drawing.Point(306, 295);
            this.btn_addCity.Name = "btn_addCity";
            this.btn_addCity.Size = new System.Drawing.Size(39, 23);
            this.btn_addCity.TabIndex = 21;
            this.btn_addCity.Text = "Add";
            this.btn_addCity.UseVisualStyleBackColor = false;
            this.btn_addCity.Click += new System.EventHandler(this.btn_addCity_Click);
            // 
            // cb_citiesList
            // 
            this.cb_citiesList.FormattingEnabled = true;
            this.cb_citiesList.Location = new System.Drawing.Point(149, 295);
            this.cb_citiesList.Name = "cb_citiesList";
            this.cb_citiesList.Size = new System.Drawing.Size(137, 23);
            this.cb_citiesList.TabIndex = 19;
            this.cb_citiesList.SelectedIndexChanged += new System.EventHandler(this.cb_citiesList_SelectedIndexChanged);
            // 
            // cb_newActiveCust
            // 
            this.cb_newActiveCust.AutoSize = true;
            this.cb_newActiveCust.Location = new System.Drawing.Point(152, 87);
            this.cb_newActiveCust.Name = "cb_newActiveCust";
            this.cb_newActiveCust.Size = new System.Drawing.Size(48, 19);
            this.cb_newActiveCust.TabIndex = 18;
            this.cb_newActiveCust.Text = "True";
            this.cb_newActiveCust.UseVisualStyleBackColor = true;
            // 
            // linkLabel_cancel
            // 
            this.linkLabel_cancel.AutoSize = true;
            this.linkLabel_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel_cancel.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel_cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_cancel.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_cancel.Location = new System.Drawing.Point(341, 595);
            this.linkLabel_cancel.Name = "linkLabel_cancel";
            this.linkLabel_cancel.Size = new System.Drawing.Size(64, 18);
            this.linkLabel_cancel.TabIndex = 17;
            this.linkLabel_cancel.TabStop = true;
            this.linkLabel_cancel.Text = "Cancel";
            this.linkLabel_cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_cancel_LinkClicked);
            // 
            // btn_CreateCustomer
            // 
            this.btn_CreateCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.btn_CreateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CreateCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_CreateCustomer.Location = new System.Drawing.Point(6, 586);
            this.btn_CreateCustomer.Name = "btn_CreateCustomer";
            this.btn_CreateCustomer.Size = new System.Drawing.Size(84, 37);
            this.btn_CreateCustomer.TabIndex = 16;
            this.btn_CreateCustomer.Text = "Create";
            this.btn_CreateCustomer.UseVisualStyleBackColor = false;
            this.btn_CreateCustomer.Click += new System.EventHandler(this.btn_CreateCustomer_Click);
            // 
            // tb_newCustPhone
            // 
            this.tb_newCustPhone.Location = new System.Drawing.Point(149, 415);
            this.tb_newCustPhone.Name = "tb_newCustPhone";
            this.tb_newCustPhone.Size = new System.Drawing.Size(240, 23);
            this.tb_newCustPhone.TabIndex = 8;
            // 
            // tb_newCustZip
            // 
            this.tb_newCustZip.Location = new System.Drawing.Point(152, 240);
            this.tb_newCustZip.Name = "tb_newCustZip";
            this.tb_newCustZip.Size = new System.Drawing.Size(93, 23);
            this.tb_newCustZip.TabIndex = 6;
            // 
            // tb_newCustAddress2
            // 
            this.tb_newCustAddress2.Location = new System.Drawing.Point(152, 191);
            this.tb_newCustAddress2.Name = "tb_newCustAddress2";
            this.tb_newCustAddress2.Size = new System.Drawing.Size(240, 23);
            this.tb_newCustAddress2.TabIndex = 4;
            // 
            // tb_newCustAddress
            // 
            this.tb_newCustAddress.Location = new System.Drawing.Point(152, 135);
            this.tb_newCustAddress.Name = "tb_newCustAddress";
            this.tb_newCustAddress.Size = new System.Drawing.Size(240, 23);
            this.tb_newCustAddress.TabIndex = 3;
            // 
            // tb_newCustName
            // 
            this.tb_newCustName.Location = new System.Drawing.Point(152, 31);
            this.tb_newCustName.Name = "tb_newCustName";
            this.tb_newCustName.Size = new System.Drawing.Size(240, 23);
            this.tb_newCustName.TabIndex = 1;
            // 
            // lbl_newCustPhone
            // 
            this.lbl_newCustPhone.AutoSize = true;
            this.lbl_newCustPhone.Location = new System.Drawing.Point(80, 418);
            this.lbl_newCustPhone.Name = "lbl_newCustPhone";
            this.lbl_newCustPhone.Size = new System.Drawing.Size(41, 15);
            this.lbl_newCustPhone.TabIndex = 7;
            this.lbl_newCustPhone.Text = "Phone";
            // 
            // lbl_newCustAdd2
            // 
            this.lbl_newCustAdd2.AutoSize = true;
            this.lbl_newCustAdd2.Location = new System.Drawing.Point(63, 199);
            this.lbl_newCustAdd2.Name = "lbl_newCustAdd2";
            this.lbl_newCustAdd2.Size = new System.Drawing.Size(58, 15);
            this.lbl_newCustAdd2.TabIndex = 6;
            this.lbl_newCustAdd2.Text = "Address 2";
            // 
            // lbl_newCustCountry
            // 
            this.lbl_newCustCountry.AutoSize = true;
            this.lbl_newCustCountry.Location = new System.Drawing.Point(71, 351);
            this.lbl_newCustCountry.Name = "lbl_newCustCountry";
            this.lbl_newCustCountry.Size = new System.Drawing.Size(50, 15);
            this.lbl_newCustCountry.TabIndex = 5;
            this.lbl_newCustCountry.Text = "Country";
            // 
            // lbl_newCustZip
            // 
            this.lbl_newCustZip.AutoSize = true;
            this.lbl_newCustZip.Location = new System.Drawing.Point(66, 248);
            this.lbl_newCustZip.Name = "lbl_newCustZip";
            this.lbl_newCustZip.Size = new System.Drawing.Size(55, 15);
            this.lbl_newCustZip.TabIndex = 4;
            this.lbl_newCustZip.Text = "Zip Code";
            // 
            // lbl_newCustCity
            // 
            this.lbl_newCustCity.AutoSize = true;
            this.lbl_newCustCity.Location = new System.Drawing.Point(93, 298);
            this.lbl_newCustCity.Name = "lbl_newCustCity";
            this.lbl_newCustCity.Size = new System.Drawing.Size(28, 15);
            this.lbl_newCustCity.TabIndex = 3;
            this.lbl_newCustCity.Text = "City";
            // 
            // lbl_newCustAddress
            // 
            this.lbl_newCustAddress.AutoSize = true;
            this.lbl_newCustAddress.Location = new System.Drawing.Point(72, 143);
            this.lbl_newCustAddress.Name = "lbl_newCustAddress";
            this.lbl_newCustAddress.Size = new System.Drawing.Size(49, 15);
            this.lbl_newCustAddress.TabIndex = 2;
            this.lbl_newCustAddress.Text = "Address";
            // 
            // lbl_active
            // 
            this.lbl_active.AutoSize = true;
            this.lbl_active.Location = new System.Drawing.Point(81, 87);
            this.lbl_active.Name = "lbl_active";
            this.lbl_active.Size = new System.Drawing.Size(40, 15);
            this.lbl_active.TabIndex = 1;
            this.lbl_active.Text = "Active";
            // 
            // lbl_custName
            // 
            this.lbl_custName.AutoSize = true;
            this.lbl_custName.Location = new System.Drawing.Point(5, 34);
            this.lbl_custName.Name = "lbl_custName";
            this.lbl_custName.Size = new System.Drawing.Size(116, 15);
            this.lbl_custName.TabIndex = 0;
            this.lbl_custName.Text = "Customer Full Name";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 650);
            this.Controls.Add(this.gb_addCustomerForm);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.gb_addCustomerForm.ResumeLayout(false);
            this.gb_addCustomerForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_addCustomerForm;
        private System.Windows.Forms.Label lbl_active;
        private System.Windows.Forms.Label lbl_custName;
        private System.Windows.Forms.Label lbl_newCustCountry;
        private System.Windows.Forms.Label lbl_newCustZip;
        private System.Windows.Forms.Label lbl_newCustAddress;
        private System.Windows.Forms.Label lbl_newCustPhone;
        private System.Windows.Forms.Label lbl_newCustAdd2;
        private System.Windows.Forms.TextBox tb_newCustName;
        private System.Windows.Forms.TextBox tb_newCustPhone;
        private System.Windows.Forms.TextBox tb_newCustZip;
        private System.Windows.Forms.TextBox tb_newCustAddress2;
        private System.Windows.Forms.TextBox tb_newCustAddress;
        private System.Windows.Forms.Button btn_CreateCustomer;
        private System.Windows.Forms.LinkLabel linkLabel_cancel;
        private System.Windows.Forms.CheckBox cb_newActiveCust;
        private System.Windows.Forms.ComboBox cb_citiesList;
        private System.Windows.Forms.Label lbl_newCustCity;
        private System.Windows.Forms.Button btn_addCity;
        private System.Windows.Forms.TextBox tb_countryName;
    }
}