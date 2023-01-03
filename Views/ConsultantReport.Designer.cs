
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
            this.SuspendLayout();
            // 
            // tb_UserSchedule
            // 
            this.tb_UserSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_UserSchedule.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_UserSchedule.Location = new System.Drawing.Point(0, 0);
            this.tb_UserSchedule.Multiline = true;
            this.tb_UserSchedule.Name = "tb_UserSchedule";
            this.tb_UserSchedule.ReadOnly = true;
            this.tb_UserSchedule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_UserSchedule.Size = new System.Drawing.Size(800, 783);
            this.tb_UserSchedule.TabIndex = 0;
            // 
            // ConsultantReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 783);
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
    }
}