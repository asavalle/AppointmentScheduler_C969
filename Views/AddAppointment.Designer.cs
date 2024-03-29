﻿
namespace AppointmentScheduler_C969.Views
{
    partial class AddAppointment
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
            this.components = new System.ComponentModel.Container();
            this.gb_addAptForm = new System.Windows.Forms.GroupBox();
            this.lb_DayOfWkWarning = new System.Windows.Forms.Label();
            this.cb_userAddApt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_aptType = new System.Windows.Forms.ComboBox();
            this.linkLabel_cancel = new System.Windows.Forms.LinkLabel();
            this.lb_contact = new System.Windows.Forms.Label();
            this.tb_aptContact = new System.Windows.Forms.TextBox();
            this.lb_aptURL = new System.Windows.Forms.Label();
            this.tb_aptURL = new System.Windows.Forms.TextBox();
            this.lb_aptLocation = new System.Windows.Forms.Label();
            this.tb_aptLocation = new System.Windows.Forms.TextBox();
            this.lb_aptType = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.cb_endTime = new System.Windows.Forms.ComboBox();
            this.lb_endTime = new System.Windows.Forms.Label();
            this.lb_startTime = new System.Windows.Forms.Label();
            this.cb_startTime = new System.Windows.Forms.ComboBox();
            this.dtp_createDate = new System.Windows.Forms.DateTimePicker();
            this.lb_aptDate = new System.Windows.Forms.Label();
            this.lb_aptDesc = new System.Windows.Forms.Label();
            this.lb_aptTitle = new System.Windows.Forms.Label();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_aptDesc = new System.Windows.Forms.TextBox();
            this.tb_aptTitle = new System.Windows.Forms.TextBox();
            this.errPr_appts = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_addAptForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPr_appts)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_addAptForm
            // 
            this.gb_addAptForm.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_addAptForm.Controls.Add(this.lb_DayOfWkWarning);
            this.gb_addAptForm.Controls.Add(this.cb_userAddApt);
            this.gb_addAptForm.Controls.Add(this.label1);
            this.gb_addAptForm.Controls.Add(this.cb_aptType);
            this.gb_addAptForm.Controls.Add(this.linkLabel_cancel);
            this.gb_addAptForm.Controls.Add(this.lb_contact);
            this.gb_addAptForm.Controls.Add(this.tb_aptContact);
            this.gb_addAptForm.Controls.Add(this.lb_aptURL);
            this.gb_addAptForm.Controls.Add(this.tb_aptURL);
            this.gb_addAptForm.Controls.Add(this.lb_aptLocation);
            this.gb_addAptForm.Controls.Add(this.tb_aptLocation);
            this.gb_addAptForm.Controls.Add(this.lb_aptType);
            this.gb_addAptForm.Controls.Add(this.btn_Create);
            this.gb_addAptForm.Controls.Add(this.cb_endTime);
            this.gb_addAptForm.Controls.Add(this.lb_endTime);
            this.gb_addAptForm.Controls.Add(this.lb_startTime);
            this.gb_addAptForm.Controls.Add(this.cb_startTime);
            this.gb_addAptForm.Controls.Add(this.dtp_createDate);
            this.gb_addAptForm.Controls.Add(this.lb_aptDate);
            this.gb_addAptForm.Controls.Add(this.lb_aptDesc);
            this.gb_addAptForm.Controls.Add(this.lb_aptTitle);
            this.gb_addAptForm.Controls.Add(this.cb_customer);
            this.gb_addAptForm.Controls.Add(this.label5);
            this.gb_addAptForm.Controls.Add(this.tb_aptDesc);
            this.gb_addAptForm.Controls.Add(this.tb_aptTitle);
            this.gb_addAptForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_addAptForm.Location = new System.Drawing.Point(12, 12);
            this.gb_addAptForm.Name = "gb_addAptForm";
            this.gb_addAptForm.Size = new System.Drawing.Size(411, 629);
            this.gb_addAptForm.TabIndex = 10;
            this.gb_addAptForm.TabStop = false;
            this.gb_addAptForm.Text = "Add New Appointment";
            // 
            // lb_DayOfWkWarning
            // 
            this.lb_DayOfWkWarning.AutoSize = true;
            this.lb_DayOfWkWarning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_DayOfWkWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_DayOfWkWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_DayOfWkWarning.ForeColor = System.Drawing.Color.Red;
            this.lb_DayOfWkWarning.Location = new System.Drawing.Point(6, 462);
            this.lb_DayOfWkWarning.Name = "lb_DayOfWkWarning";
            this.lb_DayOfWkWarning.Size = new System.Drawing.Size(361, 22);
            this.lb_DayOfWkWarning.TabIndex = 30;
            this.lb_DayOfWkWarning.Text = "Please select a date between Monday and Friday.";
            this.lb_DayOfWkWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_DayOfWkWarning.Visible = false;
            // 
            // cb_userAddApt
            // 
            this.cb_userAddApt.FormattingEnabled = true;
            this.cb_userAddApt.Location = new System.Drawing.Point(120, 74);
            this.cb_userAddApt.Name = "cb_userAddApt";
            this.cb_userAddApt.Size = new System.Drawing.Size(244, 23);
            this.cb_userAddApt.TabIndex = 2;
            this.cb_userAddApt.Validating += new System.ComponentModel.CancelEventHandler(this.cb_userAddApt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Doctor";
            // 
            // cb_aptType
            // 
            this.cb_aptType.FormattingEnabled = true;
            this.cb_aptType.ItemHeight = 15;
            this.cb_aptType.Location = new System.Drawing.Point(120, 211);
            this.cb_aptType.Name = "cb_aptType";
            this.cb_aptType.Size = new System.Drawing.Size(181, 23);
            this.cb_aptType.TabIndex = 5;
            this.cb_aptType.Validating += new System.ComponentModel.CancelEventHandler(this.cb_aptType_Validating);
            // 
            // linkLabel_cancel
            // 
            this.linkLabel_cancel.AutoSize = true;
            this.linkLabel_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel_cancel.DisabledLinkColor = System.Drawing.Color.Red;
            this.linkLabel_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel_cancel.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_cancel.Location = new System.Drawing.Point(341, 595);
            this.linkLabel_cancel.Name = "linkLabel_cancel";
            this.linkLabel_cancel.Size = new System.Drawing.Size(58, 20);
            this.linkLabel_cancel.TabIndex = 11;
            this.linkLabel_cancel.TabStop = true;
            this.linkLabel_cancel.Text = "Cancel";
            this.linkLabel_cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_cancel_LinkClicked);
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.Location = new System.Drawing.Point(63, 118);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(49, 15);
            this.lb_contact.TabIndex = 26;
            this.lb_contact.Text = "Contact";
            // 
            // tb_aptContact
            // 
            this.tb_aptContact.Location = new System.Drawing.Point(120, 115);
            this.tb_aptContact.Name = "tb_aptContact";
            this.tb_aptContact.Size = new System.Drawing.Size(244, 23);
            this.tb_aptContact.TabIndex = 3;
            this.tb_aptContact.Validating += new System.ComponentModel.CancelEventHandler(this.tb_aptContact_Validating);
            // 
            // lb_aptURL
            // 
            this.lb_aptURL.AutoSize = true;
            this.lb_aptURL.Location = new System.Drawing.Point(84, 531);
            this.lb_aptURL.Name = "lb_aptURL";
            this.lb_aptURL.Size = new System.Drawing.Size(28, 15);
            this.lb_aptURL.TabIndex = 24;
            this.lb_aptURL.Text = "URL";
            // 
            // tb_aptURL
            // 
            this.tb_aptURL.Location = new System.Drawing.Point(118, 531);
            this.tb_aptURL.Name = "tb_aptURL";
            this.tb_aptURL.Size = new System.Drawing.Size(246, 23);
            this.tb_aptURL.TabIndex = 11;
            // 
            // lb_aptLocation
            // 
            this.lb_aptLocation.AutoSize = true;
            this.lb_aptLocation.Location = new System.Drawing.Point(59, 498);
            this.lb_aptLocation.Name = "lb_aptLocation";
            this.lb_aptLocation.Size = new System.Drawing.Size(53, 15);
            this.lb_aptLocation.TabIndex = 22;
            this.lb_aptLocation.Text = "Location";
            // 
            // tb_aptLocation
            // 
            this.tb_aptLocation.Location = new System.Drawing.Point(118, 495);
            this.tb_aptLocation.Name = "tb_aptLocation";
            this.tb_aptLocation.Size = new System.Drawing.Size(246, 23);
            this.tb_aptLocation.TabIndex = 10;
            // 
            // lb_aptType
            // 
            this.lb_aptType.AutoSize = true;
            this.lb_aptType.Location = new System.Drawing.Point(81, 211);
            this.lb_aptType.Name = "lb_aptType";
            this.lb_aptType.Size = new System.Drawing.Size(31, 15);
            this.lb_aptType.TabIndex = 20;
            this.lb_aptType.Text = "Type";
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Create.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Create.Location = new System.Drawing.Point(7, 586);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(84, 37);
            this.btn_Create.TabIndex = 10;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // cb_endTime
            // 
            this.cb_endTime.FormattingEnabled = true;
            this.cb_endTime.ItemHeight = 15;
            this.cb_endTime.Location = new System.Drawing.Point(256, 436);
            this.cb_endTime.Name = "cb_endTime";
            this.cb_endTime.Size = new System.Drawing.Size(108, 23);
            this.cb_endTime.TabIndex = 9;
            this.cb_endTime.Validating += new System.ComponentModel.CancelEventHandler(this.cb_endTime_Validating);
            // 
            // lb_endTime
            // 
            this.lb_endTime.AutoSize = true;
            this.lb_endTime.Location = new System.Drawing.Point(256, 416);
            this.lb_endTime.Name = "lb_endTime";
            this.lb_endTime.Size = new System.Drawing.Size(56, 15);
            this.lb_endTime.TabIndex = 15;
            this.lb_endTime.Text = "End Time";
            // 
            // lb_startTime
            // 
            this.lb_startTime.AutoSize = true;
            this.lb_startTime.Location = new System.Drawing.Point(118, 416);
            this.lb_startTime.Name = "lb_startTime";
            this.lb_startTime.Size = new System.Drawing.Size(60, 15);
            this.lb_startTime.TabIndex = 14;
            this.lb_startTime.Text = "Start Time";
            // 
            // cb_startTime
            // 
            this.cb_startTime.FormattingEnabled = true;
            this.cb_startTime.ItemHeight = 15;
            this.cb_startTime.Location = new System.Drawing.Point(118, 436);
            this.cb_startTime.Name = "cb_startTime";
            this.cb_startTime.Size = new System.Drawing.Size(108, 23);
            this.cb_startTime.TabIndex = 8;
            this.cb_startTime.Validating += new System.ComponentModel.CancelEventHandler(this.cb_startTime_Validating);
            // 
            // dtp_createDate
            // 
            this.dtp_createDate.CustomFormat = "\"YYYY-MM-dd\"";
            this.dtp_createDate.Location = new System.Drawing.Point(118, 377);
            this.dtp_createDate.Name = "dtp_createDate";
            this.dtp_createDate.Size = new System.Drawing.Size(246, 23);
            this.dtp_createDate.TabIndex = 7;
            this.dtp_createDate.ValueChanged += new System.EventHandler(this.dtp_createDate_ValueChanged);
            this.dtp_createDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_createDate_Validating);
            // 
            // lb_aptDate
            // 
            this.lb_aptDate.AutoSize = true;
            this.lb_aptDate.Location = new System.Drawing.Point(7, 383);
            this.lb_aptDate.Name = "lb_aptDate";
            this.lb_aptDate.Size = new System.Drawing.Size(105, 15);
            this.lb_aptDate.TabIndex = 9;
            this.lb_aptDate.Text = "Appointment Date";
            // 
            // lb_aptDesc
            // 
            this.lb_aptDesc.AutoSize = true;
            this.lb_aptDesc.Location = new System.Drawing.Point(45, 257);
            this.lb_aptDesc.Name = "lb_aptDesc";
            this.lb_aptDesc.Size = new System.Drawing.Size(67, 15);
            this.lb_aptDesc.TabIndex = 8;
            this.lb_aptDesc.Text = "Description";
            // 
            // lb_aptTitle
            // 
            this.lb_aptTitle.AutoSize = true;
            this.lb_aptTitle.Location = new System.Drawing.Point(83, 161);
            this.lb_aptTitle.Name = "lb_aptTitle";
            this.lb_aptTitle.Size = new System.Drawing.Size(29, 15);
            this.lb_aptTitle.TabIndex = 7;
            this.lb_aptTitle.Text = "Title";
            // 
            // cb_customer
            // 
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(120, 28);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(244, 23);
            this.cb_customer.TabIndex = 1;
            this.cb_customer.Validating += new System.ComponentModel.CancelEventHandler(this.cb_customer_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer";
            // 
            // tb_aptDesc
            // 
            this.tb_aptDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_aptDesc.Location = new System.Drawing.Point(118, 255);
            this.tb_aptDesc.MaxLength = 250;
            this.tb_aptDesc.Multiline = true;
            this.tb_aptDesc.Name = "tb_aptDesc";
            this.tb_aptDesc.Size = new System.Drawing.Size(246, 115);
            this.tb_aptDesc.TabIndex = 6;
            // 
            // tb_aptTitle
            // 
            this.tb_aptTitle.Location = new System.Drawing.Point(118, 158);
            this.tb_aptTitle.Name = "tb_aptTitle";
            this.tb_aptTitle.Size = new System.Drawing.Size(246, 23);
            this.tb_aptTitle.TabIndex = 4;
            this.tb_aptTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tb_aptTitle_Validating);
            // 
            // errPr_appts
            // 
            this.errPr_appts.ContainerControl = this;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 650);
            this.Controls.Add(this.gb_addAptForm);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Appointment";
            this.gb_addAptForm.ResumeLayout(false);
            this.gb_addAptForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPr_appts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_addAptForm;
        private System.Windows.Forms.Label lb_aptURL;
        private System.Windows.Forms.TextBox tb_aptURL;
        private System.Windows.Forms.Label lb_aptLocation;
        private System.Windows.Forms.TextBox tb_aptLocation;
        private System.Windows.Forms.Label lb_aptType;
        private System.Windows.Forms.Button btn_AddApt;
        private System.Windows.Forms.ComboBox cb_endTime;
        private System.Windows.Forms.Label lb_endTime;
        private System.Windows.Forms.Label lb_startTime;
        private System.Windows.Forms.ComboBox cb_startTime;
        private System.Windows.Forms.DateTimePicker dtp_createDate;
        private System.Windows.Forms.Label lb_aptDate;
        private System.Windows.Forms.Label lb_aptDesc;
        private System.Windows.Forms.Label lb_aptTitle;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_aptDesc;
        private System.Windows.Forms.TextBox tb_aptTitle;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.TextBox tb_aptContact;
        private System.Windows.Forms.LinkLabel linkLabel_cancel;
        private System.Windows.Forms.ComboBox cb_aptType;
        private System.Windows.Forms.ErrorProvider errPr_appts;
        private System.Windows.Forms.ComboBox cb_userAddApt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_DayOfWkWarning;
    }
}