
namespace AppointmentScheduler_C969.Views
{
    partial class ModifyUser
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
            this.gb_modUser = new System.Windows.Forms.GroupBox();
            this.btn_modSaveUser = new System.Windows.Forms.Button();
            this.cb_modActive = new System.Windows.Forms.CheckBox();
            this.ll_modCancelUsr = new System.Windows.Forms.LinkLabel();
            this.btn_modEditUser = new System.Windows.Forms.Button();
            this.tb_modNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_modUsrPass = new System.Windows.Forms.TextBox();
            this.tb_modUsrName = new System.Windows.Forms.TextBox();
            this.lb_modOldPass = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.gb_modUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_modUser
            // 
            this.gb_modUser.BackColor = System.Drawing.Color.AliceBlue;
            this.gb_modUser.Controls.Add(this.btn_modSaveUser);
            this.gb_modUser.Controls.Add(this.cb_modActive);
            this.gb_modUser.Controls.Add(this.ll_modCancelUsr);
            this.gb_modUser.Controls.Add(this.btn_modEditUser);
            this.gb_modUser.Controls.Add(this.tb_modNewPass);
            this.gb_modUser.Controls.Add(this.label1);
            this.gb_modUser.Controls.Add(this.tb_modUsrPass);
            this.gb_modUser.Controls.Add(this.tb_modUsrName);
            this.gb_modUser.Controls.Add(this.lb_modOldPass);
            this.gb_modUser.Controls.Add(this.lb_userName);
            this.gb_modUser.Location = new System.Drawing.Point(12, 12);
            this.gb_modUser.Name = "gb_modUser";
            this.gb_modUser.Size = new System.Drawing.Size(412, 313);
            this.gb_modUser.TabIndex = 0;
            this.gb_modUser.TabStop = false;
            this.gb_modUser.Text = "Modify User";
            // 
            // btn_modSaveUser
            // 
            this.btn_modSaveUser.BackColor = System.Drawing.Color.LightBlue;
            this.btn_modSaveUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modSaveUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_modSaveUser.Location = new System.Drawing.Point(96, 270);
            this.btn_modSaveUser.Name = "btn_modSaveUser";
            this.btn_modSaveUser.Size = new System.Drawing.Size(84, 37);
            this.btn_modSaveUser.TabIndex = 11;
            this.btn_modSaveUser.Text = "Save";
            this.btn_modSaveUser.UseVisualStyleBackColor = false;
            this.btn_modSaveUser.Visible = false;
            this.btn_modSaveUser.Click += new System.EventHandler(this.btn_modSaveUser_Click);
            // 
            // cb_modActive
            // 
            this.cb_modActive.AutoSize = true;
            this.cb_modActive.Enabled = false;
            this.cb_modActive.Location = new System.Drawing.Point(133, 84);
            this.cb_modActive.Name = "cb_modActive";
            this.cb_modActive.Size = new System.Drawing.Size(67, 19);
            this.cb_modActive.TabIndex = 10;
            this.cb_modActive.Text = "Active ?";
            this.cb_modActive.UseVisualStyleBackColor = true;
            // 
            // ll_modCancelUsr
            // 
            this.ll_modCancelUsr.AutoSize = true;
            this.ll_modCancelUsr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ll_modCancelUsr.LinkColor = System.Drawing.Color.Red;
            this.ll_modCancelUsr.Location = new System.Drawing.Point(342, 279);
            this.ll_modCancelUsr.Name = "ll_modCancelUsr";
            this.ll_modCancelUsr.Size = new System.Drawing.Size(64, 18);
            this.ll_modCancelUsr.TabIndex = 9;
            this.ll_modCancelUsr.TabStop = true;
            this.ll_modCancelUsr.Text = "Cancel";
            this.ll_modCancelUsr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_modCancelUsr_LinkClicked);
            // 
            // btn_modEditUser
            // 
            this.btn_modEditUser.BackColor = System.Drawing.Color.LightBlue;
            this.btn_modEditUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_modEditUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_modEditUser.Location = new System.Drawing.Point(6, 270);
            this.btn_modEditUser.Name = "btn_modEditUser";
            this.btn_modEditUser.Size = new System.Drawing.Size(84, 37);
            this.btn_modEditUser.TabIndex = 8;
            this.btn_modEditUser.Text = "Edit";
            this.btn_modEditUser.UseVisualStyleBackColor = false;
            this.btn_modEditUser.Click += new System.EventHandler(this.btn_modEditUser_Click);
            // 
            // tb_modNewPass
            // 
            this.tb_modNewPass.Enabled = false;
            this.tb_modNewPass.Location = new System.Drawing.Point(133, 190);
            this.tb_modNewPass.Name = "tb_modNewPass";
            this.tb_modNewPass.Size = new System.Drawing.Size(196, 23);
            this.tb_modNewPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Password";
            // 
            // tb_modUsrPass
            // 
            this.tb_modUsrPass.Enabled = false;
            this.tb_modUsrPass.Location = new System.Drawing.Point(133, 122);
            this.tb_modUsrPass.Name = "tb_modUsrPass";
            this.tb_modUsrPass.ReadOnly = true;
            this.tb_modUsrPass.Size = new System.Drawing.Size(196, 23);
            this.tb_modUsrPass.TabIndex = 3;
            // 
            // tb_modUsrName
            // 
            this.tb_modUsrName.Enabled = false;
            this.tb_modUsrName.Location = new System.Drawing.Point(133, 39);
            this.tb_modUsrName.Name = "tb_modUsrName";
            this.tb_modUsrName.Size = new System.Drawing.Size(196, 23);
            this.tb_modUsrName.TabIndex = 2;
            // 
            // lb_modOldPass
            // 
            this.lb_modOldPass.AutoSize = true;
            this.lb_modOldPass.Location = new System.Drawing.Point(48, 125);
            this.lb_modOldPass.Name = "lb_modOldPass";
            this.lb_modOldPass.Size = new System.Drawing.Size(79, 15);
            this.lb_modOldPass.TabIndex = 1;
            this.lb_modOldPass.Text = "Old Password";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(62, 42);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(65, 15);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "User Name";
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 337);
            this.Controls.Add(this.gb_modUser);
            this.Name = "ModifyUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyUser";
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            this.gb_modUser.ResumeLayout(false);
            this.gb_modUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_modUser;
        private System.Windows.Forms.Label lb_modOldPass;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.TextBox tb_modUsrPass;
        private System.Windows.Forms.TextBox tb_modUsrName;
        private System.Windows.Forms.TextBox tb_modNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modEditUser;
        private System.Windows.Forms.LinkLabel ll_modCancelUsr;
        private System.Windows.Forms.CheckBox cb_modActive;
        private System.Windows.Forms.Button btn_modSaveUser;
    }
}