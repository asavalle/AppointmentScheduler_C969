
namespace AppointmentScheduler_C969
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.pan_uname = new System.Windows.Forms.Panel();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_userPwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancelLogin = new System.Windows.Forms.Button();
            this.pan_uname.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            resources.ApplyResources(this.lb_userName, "lb_userName");
            this.lb_userName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_userName.Name = "lb_userName";
            // 
            // lb_password
            // 
            resources.ApplyResources(this.lb_password, "lb_password");
            this.lb_password.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_password.Name = "lb_password";
            // 
            // pan_uname
            // 
            resources.ApplyResources(this.pan_uname, "pan_uname");
            this.pan_uname.BackColor = System.Drawing.SystemColors.Window;
            this.pan_uname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_uname.Controls.Add(this.tb_UserName);
            this.pan_uname.Name = "pan_uname";
            // 
            // tb_UserName
            // 
            resources.ApplyResources(this.tb_UserName, "tb_UserName");
            this.tb_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_UserName.Name = "tb_UserName";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_userPwd);
            this.panel2.Name = "panel2";
            // 
            // tb_userPwd
            // 
            resources.ApplyResources(this.tb_userPwd, "tb_userPwd");
            this.tb_userPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_userPwd.Name = "tb_userPwd";
            // 
            // btn_login
            // 
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancelLogin
            // 
            resources.ApplyResources(this.btn_cancelLogin, "btn_cancelLogin");
            this.btn_cancelLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_cancelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelLogin.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_cancelLogin.Name = "btn_cancelLogin";
            this.btn_cancelLogin.UseVisualStyleBackColor = false;
            this.btn_cancelLogin.Click += new System.EventHandler(this.btn_cancelLogin_Click);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.btn_cancelLogin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pan_uname);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_userName);
            this.Name = "login";
            this.pan_uname.ResumeLayout(false);
            this.pan_uname.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Panel pan_uname;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_userPwd;
        public System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.Button btn_cancelLogin;
    }
}

