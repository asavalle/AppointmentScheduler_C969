
namespace AppointmentScheduler_C969.Views
{
    partial class AppointmentsByMonthType
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
            this.tb_aptsByMonthType = new System.Windows.Forms.TextBox();
            this.cb_aptTypes = new System.Windows.Forms.ComboBox();
            this.lb_aptType = new System.Windows.Forms.Label();
            this.cb_months = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_displayReport = new System.Windows.Forms.Button();
            this.btn_clearReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_aptsByMonthType
            // 
            this.tb_aptsByMonthType.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_aptsByMonthType.Location = new System.Drawing.Point(0, 0);
            this.tb_aptsByMonthType.Multiline = true;
            this.tb_aptsByMonthType.Name = "tb_aptsByMonthType";
            this.tb_aptsByMonthType.ReadOnly = true;
            this.tb_aptsByMonthType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_aptsByMonthType.Size = new System.Drawing.Size(1061, 783);
            this.tb_aptsByMonthType.TabIndex = 0;
            // 
            // cb_aptTypes
            // 
            this.cb_aptTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_aptTypes.FormattingEnabled = true;
            this.cb_aptTypes.Location = new System.Drawing.Point(1117, 62);
            this.cb_aptTypes.Name = "cb_aptTypes";
            this.cb_aptTypes.Size = new System.Drawing.Size(231, 23);
            this.cb_aptTypes.TabIndex = 1;
            // 
            // lb_aptType
            // 
            this.lb_aptType.AutoSize = true;
            this.lb_aptType.Location = new System.Drawing.Point(1117, 41);
            this.lb_aptType.Name = "lb_aptType";
            this.lb_aptType.Size = new System.Drawing.Size(105, 15);
            this.lb_aptType.TabIndex = 2;
            this.lb_aptType.Text = "Appointment Type";
            // 
            // cb_months
            // 
            this.cb_months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_months.FormattingEnabled = true;
            this.cb_months.Location = new System.Drawing.Point(1117, 141);
            this.cb_months.Name = "cb_months";
            this.cb_months.Size = new System.Drawing.Size(231, 23);
            this.cb_months.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1117, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Month";
            // 
            // btn_displayReport
            // 
            this.btn_displayReport.BackColor = System.Drawing.Color.LightBlue;
            this.btn_displayReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_displayReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_displayReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_displayReport.Location = new System.Drawing.Point(1117, 199);
            this.btn_displayReport.Name = "btn_displayReport";
            this.btn_displayReport.Size = new System.Drawing.Size(88, 43);
            this.btn_displayReport.TabIndex = 5;
            this.btn_displayReport.Text = "Display";
            this.btn_displayReport.UseVisualStyleBackColor = false;
            this.btn_displayReport.Click += new System.EventHandler(this.btn_displayReport_Click);
            // 
            // btn_clearReport
            // 
            this.btn_clearReport.BackColor = System.Drawing.Color.LightBlue;
            this.btn_clearReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clearReport.Location = new System.Drawing.Point(1261, 199);
            this.btn_clearReport.Name = "btn_clearReport";
            this.btn_clearReport.Size = new System.Drawing.Size(88, 43);
            this.btn_clearReport.TabIndex = 6;
            this.btn_clearReport.Text = "Clear";
            this.btn_clearReport.UseVisualStyleBackColor = false;
            // 
            // AppointmentsByMonthType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 783);
            this.Controls.Add(this.btn_clearReport);
            this.Controls.Add(this.btn_displayReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_months);
            this.Controls.Add(this.lb_aptType);
            this.Controls.Add(this.cb_aptTypes);
            this.Controls.Add(this.tb_aptsByMonthType);
            this.Name = "AppointmentsByMonthType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsByMonthType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_aptsByMonthType;
        private System.Windows.Forms.ComboBox cb_aptTypes;
        private System.Windows.Forms.Label lb_aptType;
        private System.Windows.Forms.ComboBox cb_months;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_displayReport;
        private System.Windows.Forms.Button btn_clearReport;
    }
}