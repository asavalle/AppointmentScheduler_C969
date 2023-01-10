
namespace AppointmentScheduler_C969.Views
{
    partial class AppointmentsByCustomer
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
            this.tb_aptsByCustomer = new System.Windows.Forms.TextBox();
            this.lb_aptByCity = new System.Windows.Forms.Label();
            this.cb_custName = new System.Windows.Forms.ComboBox();
            this.btn_DisplayByCity = new System.Windows.Forms.Button();
            this.btn_clearReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_aptsByCustomer
            // 
            this.tb_aptsByCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_aptsByCustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_aptsByCustomer.Location = new System.Drawing.Point(0, 0);
            this.tb_aptsByCustomer.Multiline = true;
            this.tb_aptsByCustomer.Name = "tb_aptsByCustomer";
            this.tb_aptsByCustomer.ReadOnly = true;
            this.tb_aptsByCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_aptsByCustomer.Size = new System.Drawing.Size(1061, 783);
            this.tb_aptsByCustomer.TabIndex = 0;
            // 
            // lb_aptByCity
            // 
            this.lb_aptByCity.AutoSize = true;
            this.lb_aptByCity.Location = new System.Drawing.Point(1139, 113);
            this.lb_aptByCity.Name = "lb_aptByCity";
            this.lb_aptByCity.Size = new System.Drawing.Size(28, 15);
            this.lb_aptByCity.TabIndex = 1;
            this.lb_aptByCity.Text = "City";
            // 
            // cb_custName
            // 
            this.cb_custName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_custName.FormattingEnabled = true;
            this.cb_custName.Location = new System.Drawing.Point(1139, 131);
            this.cb_custName.Name = "cb_custName";
            this.cb_custName.Size = new System.Drawing.Size(225, 23);
            this.cb_custName.TabIndex = 2;
            // 
            // btn_DisplayByCity
            // 
            this.btn_DisplayByCity.BackColor = System.Drawing.Color.LightBlue;
            this.btn_DisplayByCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisplayByCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DisplayByCity.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_DisplayByCity.Location = new System.Drawing.Point(1139, 178);
            this.btn_DisplayByCity.Name = "btn_DisplayByCity";
            this.btn_DisplayByCity.Size = new System.Drawing.Size(99, 42);
            this.btn_DisplayByCity.TabIndex = 5;
            this.btn_DisplayByCity.Text = "Display";
            this.btn_DisplayByCity.UseVisualStyleBackColor = false;
            this.btn_DisplayByCity.Click += new System.EventHandler(this.btn_DisplayByCity_Click);
            // 
            // btn_clearReport
            // 
            this.btn_clearReport.BackColor = System.Drawing.Color.LightBlue;
            this.btn_clearReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clearReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_clearReport.Location = new System.Drawing.Point(1265, 178);
            this.btn_clearReport.Name = "btn_clearReport";
            this.btn_clearReport.Size = new System.Drawing.Size(99, 42);
            this.btn_clearReport.TabIndex = 6;
            this.btn_clearReport.Text = "Clear";
            this.btn_clearReport.UseVisualStyleBackColor = false;
            this.btn_clearReport.Click += new System.EventHandler(this.btn_clearReport_Click);
            // 
            // AppointmentsByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 783);
            this.Controls.Add(this.btn_clearReport);
            this.Controls.Add(this.btn_DisplayByCity);
            this.Controls.Add(this.cb_custName);
            this.Controls.Add(this.lb_aptByCity);
            this.Controls.Add(this.tb_aptsByCustomer);
            this.Name = "AppointmentsByCustomer";
            this.Text = "AppointmentsByCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_aptByCity;
        private System.Windows.Forms.ComboBox cb_aptByCity;
        private System.Windows.Forms.Button btn_DisplayByCity;
        private System.Windows.Forms.Button btn_clearReport;
        private System.Windows.Forms.TextBox tb_aptsByCustomer;
        private System.Windows.Forms.ComboBox cb_custName;
    }
}