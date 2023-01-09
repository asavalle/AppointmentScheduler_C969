
namespace AppointmentScheduler_C969.Views
{
    partial class ConsultantReport
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
            this.tb_UserSchedule = new System.Windows.Forms.TextBox();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.cb_reportUsrSelect = new System.Windows.Forms.ComboBox();
            this.lb_usr = new System.Windows.Forms.Label();
            this.btn_usrReportDisplay = new System.Windows.Forms.Button();
            this.btn_clearReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_UserSchedule
            // 
            this.tb_UserSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_UserSchedule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_UserSchedule.Location = new System.Drawing.Point(0, 0);
            this.tb_UserSchedule.Multiline = true;
            this.tb_UserSchedule.Name = "tb_UserSchedule";
            this.tb_UserSchedule.ReadOnly = true;
            this.tb_UserSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_UserSchedule.Size = new System.Drawing.Size(1061, 783);
            this.tb_UserSchedule.TabIndex = 0;
            // 
            // btn_showAll
            // 
            this.btn_showAll.BackColor = System.Drawing.Color.LightBlue;
            this.btn_showAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showAll.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_showAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_showAll.Location = new System.Drawing.Point(1121, 207);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(99, 42);
            this.btn_showAll.TabIndex = 1;
            this.btn_showAll.Text = "All";
            this.btn_showAll.UseVisualStyleBackColor = false;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // cb_reportUsrSelect
            // 
            this.cb_reportUsrSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_reportUsrSelect.FormattingEnabled = true;
            this.cb_reportUsrSelect.Location = new System.Drawing.Point(1121, 73);
            this.cb_reportUsrSelect.Name = "cb_reportUsrSelect";
            this.cb_reportUsrSelect.Size = new System.Drawing.Size(226, 23);
            this.cb_reportUsrSelect.TabIndex = 2;
            // 
            // lb_usr
            // 
            this.lb_usr.AutoSize = true;
            this.lb_usr.Location = new System.Drawing.Point(1121, 52);
            this.lb_usr.Name = "lb_usr";
            this.lb_usr.Size = new System.Drawing.Size(99, 15);
            this.lb_usr.TabIndex = 3;
            this.lb_usr.Text = "Consultant (User)";
            // 
            // btn_usrReportDisplay
            // 
            this.btn_usrReportDisplay.BackColor = System.Drawing.Color.LightBlue;
            this.btn_usrReportDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usrReportDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_usrReportDisplay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_usrReportDisplay.Location = new System.Drawing.Point(1121, 113);
            this.btn_usrReportDisplay.Name = "btn_usrReportDisplay";
            this.btn_usrReportDisplay.Size = new System.Drawing.Size(99, 42);
            this.btn_usrReportDisplay.TabIndex = 4;
            this.btn_usrReportDisplay.Text = "Display";
            this.btn_usrReportDisplay.UseVisualStyleBackColor = false;
            this.btn_usrReportDisplay.Click += new System.EventHandler(this.btn_usrReportDisplay_Click);
            // 
            // btn_clearReport
            // 
            this.btn_clearReport.BackColor = System.Drawing.Color.LightBlue;
            this.btn_clearReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clearReport.Location = new System.Drawing.Point(1248, 113);
            this.btn_clearReport.Name = "btn_clearReport";
            this.btn_clearReport.Size = new System.Drawing.Size(99, 42);
            this.btn_clearReport.TabIndex = 5;
            this.btn_clearReport.Text = "Clear";
            this.btn_clearReport.UseVisualStyleBackColor = false;
            this.btn_clearReport.Click += new System.EventHandler(this.btn_clearReport_Click);
            // 
            // ConsultantReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 783);
            this.Controls.Add(this.btn_clearReport);
            this.Controls.Add(this.btn_usrReportDisplay);
            this.Controls.Add(this.lb_usr);
            this.Controls.Add(this.cb_reportUsrSelect);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.tb_UserSchedule);
            this.Name = "ConsultantReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultantReport";
            this.Load += new System.EventHandler(this.ConsultantReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_UserSchedule;
        private System.Windows.Forms.Button btn_showAll;
        private System.Windows.Forms.ComboBox cb_reportUsrSelect;
        private System.Windows.Forms.Label lb_usr;
        private System.Windows.Forms.Button btn_usrReportDisplay;
        private System.Windows.Forms.Button btn_clearReport;
    }
}