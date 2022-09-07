
namespace AppointmentScheduler_C969.Views
{
    partial class ModifyAppointment
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
            this.gb_modAptForm = new System.Windows.Forms.GroupBox();
            this.linkLabel_modCancel = new System.Windows.Forms.LinkLabel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_editApt = new System.Windows.Forms.Button();
            this.lb_modURL = new System.Windows.Forms.Label();
            this.lb_modLocation = new System.Windows.Forms.Label();
            this.lb_modETime = new System.Windows.Forms.Label();
            this.lb_modSTime = new System.Windows.Forms.Label();
            this.lb_modDate = new System.Windows.Forms.Label();
            this.lb_modDesc = new System.Windows.Forms.Label();
            this.lb_modType = new System.Windows.Forms.Label();
            this.lb_modTitle = new System.Windows.Forms.Label();
            this.lb_modContact = new System.Windows.Forms.Label();
            this.lb_modCustomer = new System.Windows.Forms.Label();
            this.tb_modURL = new System.Windows.Forms.TextBox();
            this.tb_modLocation = new System.Windows.Forms.TextBox();
            this.cb_modETime = new System.Windows.Forms.ComboBox();
            this.cb_modSTime = new System.Windows.Forms.ComboBox();
            this.dtp_modDate = new System.Windows.Forms.DateTimePicker();
            this.tb_modDescription = new System.Windows.Forms.TextBox();
            this.tb_modType = new System.Windows.Forms.TextBox();
            this.tb_modTitle = new System.Windows.Forms.TextBox();
            this.tb_modContact = new System.Windows.Forms.TextBox();
            this.cb_modCustomer = new System.Windows.Forms.ComboBox();
            this.tb_aptID = new System.Windows.Forms.TextBox();
            this.lb_aptIdLabel = new System.Windows.Forms.Label();
            this.gb_modAptForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_modAptForm
            // 
            this.gb_modAptForm.Controls.Add(this.lb_aptIdLabel);
            this.gb_modAptForm.Controls.Add(this.tb_aptID);
            this.gb_modAptForm.Controls.Add(this.linkLabel_modCancel);
            this.gb_modAptForm.Controls.Add(this.btn_Save);
            this.gb_modAptForm.Controls.Add(this.btn_editApt);
            this.gb_modAptForm.Controls.Add(this.lb_modURL);
            this.gb_modAptForm.Controls.Add(this.lb_modLocation);
            this.gb_modAptForm.Controls.Add(this.lb_modETime);
            this.gb_modAptForm.Controls.Add(this.lb_modSTime);
            this.gb_modAptForm.Controls.Add(this.lb_modDate);
            this.gb_modAptForm.Controls.Add(this.lb_modDesc);
            this.gb_modAptForm.Controls.Add(this.lb_modType);
            this.gb_modAptForm.Controls.Add(this.lb_modTitle);
            this.gb_modAptForm.Controls.Add(this.lb_modContact);
            this.gb_modAptForm.Controls.Add(this.lb_modCustomer);
            this.gb_modAptForm.Controls.Add(this.tb_modURL);
            this.gb_modAptForm.Controls.Add(this.tb_modLocation);
            this.gb_modAptForm.Controls.Add(this.cb_modETime);
            this.gb_modAptForm.Controls.Add(this.cb_modSTime);
            this.gb_modAptForm.Controls.Add(this.dtp_modDate);
            this.gb_modAptForm.Controls.Add(this.tb_modDescription);
            this.gb_modAptForm.Controls.Add(this.tb_modType);
            this.gb_modAptForm.Controls.Add(this.tb_modTitle);
            this.gb_modAptForm.Controls.Add(this.tb_modContact);
            this.gb_modAptForm.Controls.Add(this.cb_modCustomer);
            this.gb_modAptForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_modAptForm.Location = new System.Drawing.Point(12, 12);
            this.gb_modAptForm.Name = "gb_modAptForm";
            this.gb_modAptForm.Size = new System.Drawing.Size(411, 629);
            this.gb_modAptForm.TabIndex = 0;
            this.gb_modAptForm.TabStop = false;
            this.gb_modAptForm.Text = "Modify Appointment";
            // 
            // linkLabel_modCancel
            // 
            this.linkLabel_modCancel.AutoSize = true;
            this.linkLabel_modCancel.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel_modCancel.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel_modCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_modCancel.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_modCancel.Location = new System.Drawing.Point(341, 605);
            this.linkLabel_modCancel.Name = "linkLabel_modCancel";
            this.linkLabel_modCancel.Size = new System.Drawing.Size(64, 18);
            this.linkLabel_modCancel.TabIndex = 38;
            this.linkLabel_modCancel.TabStop = true;
            this.linkLabel_modCancel.Text = "Cancel";
            this.linkLabel_modCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_modCancel_LinkClicked);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Save.Location = new System.Drawing.Point(116, 586);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(84, 37);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_editApt
            // 
            this.btn_editApt.BackColor = System.Drawing.Color.LightBlue;
            this.btn_editApt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editApt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_editApt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_editApt.Location = new System.Drawing.Point(6, 586);
            this.btn_editApt.Name = "btn_editApt";
            this.btn_editApt.Size = new System.Drawing.Size(84, 37);
            this.btn_editApt.TabIndex = 36;
            this.btn_editApt.Text = "Edit";
            this.btn_editApt.UseVisualStyleBackColor = false;
            this.btn_editApt.Click += new System.EventHandler(this.btn_editApt_Click);
            // 
            // lb_modURL
            // 
            this.lb_modURL.AutoSize = true;
            this.lb_modURL.Location = new System.Drawing.Point(78, 540);
            this.lb_modURL.Name = "lb_modURL";
            this.lb_modURL.Size = new System.Drawing.Size(28, 15);
            this.lb_modURL.TabIndex = 35;
            this.lb_modURL.Text = "URL";
            // 
            // lb_modLocation
            // 
            this.lb_modLocation.AutoSize = true;
            this.lb_modLocation.Location = new System.Drawing.Point(53, 502);
            this.lb_modLocation.Name = "lb_modLocation";
            this.lb_modLocation.Size = new System.Drawing.Size(53, 15);
            this.lb_modLocation.TabIndex = 34;
            this.lb_modLocation.Text = "Location";
            // 
            // lb_modETime
            // 
            this.lb_modETime.AutoSize = true;
            this.lb_modETime.Location = new System.Drawing.Point(50, 470);
            this.lb_modETime.Name = "lb_modETime";
            this.lb_modETime.Size = new System.Drawing.Size(56, 15);
            this.lb_modETime.TabIndex = 33;
            this.lb_modETime.Text = "End Time";
            // 
            // lb_modSTime
            // 
            this.lb_modSTime.AutoSize = true;
            this.lb_modSTime.Location = new System.Drawing.Point(46, 441);
            this.lb_modSTime.Name = "lb_modSTime";
            this.lb_modSTime.Size = new System.Drawing.Size(60, 15);
            this.lb_modSTime.TabIndex = 32;
            this.lb_modSTime.Text = "Start Time";
            // 
            // lb_modDate
            // 
            this.lb_modDate.AutoSize = true;
            this.lb_modDate.Location = new System.Drawing.Point(1, 401);
            this.lb_modDate.Name = "lb_modDate";
            this.lb_modDate.Size = new System.Drawing.Size(105, 15);
            this.lb_modDate.TabIndex = 31;
            this.lb_modDate.Text = "Appointment Date";
            // 
            // lb_modDesc
            // 
            this.lb_modDesc.AutoSize = true;
            this.lb_modDesc.Location = new System.Drawing.Point(39, 268);
            this.lb_modDesc.Name = "lb_modDesc";
            this.lb_modDesc.Size = new System.Drawing.Size(67, 15);
            this.lb_modDesc.TabIndex = 30;
            this.lb_modDesc.Text = "Description";
            // 
            // lb_modType
            // 
            this.lb_modType.AutoSize = true;
            this.lb_modType.Location = new System.Drawing.Point(75, 216);
            this.lb_modType.Name = "lb_modType";
            this.lb_modType.Size = new System.Drawing.Size(31, 15);
            this.lb_modType.TabIndex = 29;
            this.lb_modType.Text = "Type";
            // 
            // lb_modTitle
            // 
            this.lb_modTitle.AutoSize = true;
            this.lb_modTitle.Location = new System.Drawing.Point(77, 171);
            this.lb_modTitle.Name = "lb_modTitle";
            this.lb_modTitle.Size = new System.Drawing.Size(29, 15);
            this.lb_modTitle.TabIndex = 28;
            this.lb_modTitle.Text = "Title";
            // 
            // lb_modContact
            // 
            this.lb_modContact.AutoSize = true;
            this.lb_modContact.Location = new System.Drawing.Point(57, 130);
            this.lb_modContact.Name = "lb_modContact";
            this.lb_modContact.Size = new System.Drawing.Size(49, 15);
            this.lb_modContact.TabIndex = 27;
            this.lb_modContact.Text = "Contact";
            // 
            // lb_modCustomer
            // 
            this.lb_modCustomer.AutoSize = true;
            this.lb_modCustomer.Location = new System.Drawing.Point(47, 90);
            this.lb_modCustomer.Name = "lb_modCustomer";
            this.lb_modCustomer.Size = new System.Drawing.Size(59, 15);
            this.lb_modCustomer.TabIndex = 25;
            this.lb_modCustomer.Text = "Customer";
            // 
            // tb_modURL
            // 
            this.tb_modURL.Enabled = false;
            this.tb_modURL.Location = new System.Drawing.Point(116, 537);
            this.tb_modURL.Name = "tb_modURL";
            this.tb_modURL.Size = new System.Drawing.Size(289, 23);
            this.tb_modURL.TabIndex = 9;
            // 
            // tb_modLocation
            // 
            this.tb_modLocation.Enabled = false;
            this.tb_modLocation.Location = new System.Drawing.Point(116, 499);
            this.tb_modLocation.Name = "tb_modLocation";
            this.tb_modLocation.Size = new System.Drawing.Size(246, 23);
            this.tb_modLocation.TabIndex = 8;
            // 
            // cb_modETime
            // 
            this.cb_modETime.Enabled = false;
            this.cb_modETime.FormattingEnabled = true;
            this.cb_modETime.Location = new System.Drawing.Point(116, 467);
            this.cb_modETime.Name = "cb_modETime";
            this.cb_modETime.Size = new System.Drawing.Size(108, 23);
            this.cb_modETime.TabIndex = 7;
            // 
            // cb_modSTime
            // 
            this.cb_modSTime.Enabled = false;
            this.cb_modSTime.FormattingEnabled = true;
            this.cb_modSTime.Location = new System.Drawing.Point(116, 438);
            this.cb_modSTime.Name = "cb_modSTime";
            this.cb_modSTime.Size = new System.Drawing.Size(108, 23);
            this.cb_modSTime.TabIndex = 6;
            // 
            // dtp_modDate
            // 
            this.dtp_modDate.Enabled = false;
            this.dtp_modDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_modDate.Location = new System.Drawing.Point(116, 395);
            this.dtp_modDate.Name = "dtp_modDate";
            this.dtp_modDate.Size = new System.Drawing.Size(246, 23);
            this.dtp_modDate.TabIndex = 5;
            // 
            // tb_modDescription
            // 
            this.tb_modDescription.Enabled = false;
            this.tb_modDescription.Location = new System.Drawing.Point(116, 265);
            this.tb_modDescription.Multiline = true;
            this.tb_modDescription.Name = "tb_modDescription";
            this.tb_modDescription.Size = new System.Drawing.Size(246, 115);
            this.tb_modDescription.TabIndex = 4;
            // 
            // tb_modType
            // 
            this.tb_modType.Enabled = false;
            this.tb_modType.Location = new System.Drawing.Point(116, 213);
            this.tb_modType.Name = "tb_modType";
            this.tb_modType.Size = new System.Drawing.Size(246, 23);
            this.tb_modType.TabIndex = 3;
            // 
            // tb_modTitle
            // 
            this.tb_modTitle.Enabled = false;
            this.tb_modTitle.Location = new System.Drawing.Point(116, 168);
            this.tb_modTitle.Name = "tb_modTitle";
            this.tb_modTitle.Size = new System.Drawing.Size(246, 23);
            this.tb_modTitle.TabIndex = 2;
            // 
            // tb_modContact
            // 
            this.tb_modContact.Enabled = false;
            this.tb_modContact.Location = new System.Drawing.Point(116, 127);
            this.tb_modContact.Name = "tb_modContact";
            this.tb_modContact.Size = new System.Drawing.Size(246, 23);
            this.tb_modContact.TabIndex = 1;
            // 
            // cb_modCustomer
            // 
            this.cb_modCustomer.Enabled = false;
            this.cb_modCustomer.FormattingEnabled = true;
            this.cb_modCustomer.Location = new System.Drawing.Point(116, 87);
            this.cb_modCustomer.Name = "cb_modCustomer";
            this.cb_modCustomer.Size = new System.Drawing.Size(246, 23);
            this.cb_modCustomer.Sorted = true;
            this.cb_modCustomer.TabIndex = 0;
            // 
            // tb_aptID
            // 
            this.tb_aptID.Enabled = false;
            this.tb_aptID.Location = new System.Drawing.Point(116, 45);
            this.tb_aptID.Name = "tb_aptID";
            this.tb_aptID.ReadOnly = true;
            this.tb_aptID.Size = new System.Drawing.Size(84, 23);
            this.tb_aptID.TabIndex = 39;
            // 
            // lb_aptIdLabel
            // 
            this.lb_aptIdLabel.AutoSize = true;
            this.lb_aptIdLabel.Location = new System.Drawing.Point(14, 48);
            this.lb_aptIdLabel.Name = "lb_aptIdLabel";
            this.lb_aptIdLabel.Size = new System.Drawing.Size(92, 15);
            this.lb_aptIdLabel.TabIndex = 40;
            this.lb_aptIdLabel.Text = "Appointment ID";
            // 
            // ModifyAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 650);
            this.Controls.Add(this.gb_modAptForm);
            this.Name = "ModifyAppointment";
            this.Text = "ModifyAppointment";
            this.Load += new System.EventHandler(this.ModifyAppointment_Load);
            this.gb_modAptForm.ResumeLayout(false);
            this.gb_modAptForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_modAptForm;
        private System.Windows.Forms.TextBox tb_modDescription;
        private System.Windows.Forms.DateTimePicker dtp_modDate;
        private System.Windows.Forms.ComboBox cb_modETime;
        private System.Windows.Forms.ComboBox cb_modSTime;
        private System.Windows.Forms.TextBox tb_modLocation;
        private System.Windows.Forms.TextBox tb_modURL;
        private System.Windows.Forms.Label lb_modCustomer;
        private System.Windows.Forms.Label lb_modContact;
        private System.Windows.Forms.Label lb_modTitle;
        private System.Windows.Forms.Label lb_modType;
        private System.Windows.Forms.Label lb_modDesc;
        private System.Windows.Forms.Label lb_modDate;
        private System.Windows.Forms.Label lb_modSTime;
        private System.Windows.Forms.Label lb_modETime;
        private System.Windows.Forms.Label lb_modLocation;
        private System.Windows.Forms.Label lb_modURL;
        private System.Windows.Forms.Button btn_editApt;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.LinkLabel linkLabel_modCancel;
        public System.Windows.Forms.TextBox tb_modContact;
        public System.Windows.Forms.ComboBox cb_modCustomer;
        public System.Windows.Forms.TextBox tb_modType;
        public System.Windows.Forms.TextBox tb_modTitle;
        private System.Windows.Forms.Label lb_aptIdLabel;
        public System.Windows.Forms.TextBox tb_aptID;
    }
}