
namespace AppointmentScheduler_C969.Views
{
    partial class AddUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ll_cancelUsrAdd = new System.Windows.Forms.LinkLabel();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.lb_isUsrActive = new System.Windows.Forms.Label();
            this.cb_isUsrActive = new System.Windows.Forms.CheckBox();
            this.tb_userPass = new System.Windows.Forms.TextBox();
            this.tb_usrName = new System.Windows.Forms.TextBox();
            this.lb_usrPass = new System.Windows.Forms.Label();
            this.lb_usrName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.ll_cancelUsrAdd);
            this.groupBox1.Controls.Add(this.btn_AddUser);
            this.groupBox1.Controls.Add(this.lb_isUsrActive);
            this.groupBox1.Controls.Add(this.cb_isUsrActive);
            this.groupBox1.Controls.Add(this.tb_userPass);
            this.groupBox1.Controls.Add(this.tb_usrName);
            this.groupBox1.Controls.Add(this.lb_usrPass);
            this.groupBox1.Controls.Add(this.lb_usrName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User/Consultant";
            // 
            // ll_cancelUsrAdd
            // 
            this.ll_cancelUsrAdd.AutoSize = true;
            this.ll_cancelUsrAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ll_cancelUsrAdd.LinkColor = System.Drawing.Color.Red;
            this.ll_cancelUsrAdd.Location = new System.Drawing.Point(454, 299);
            this.ll_cancelUsrAdd.Name = "ll_cancelUsrAdd";
            this.ll_cancelUsrAdd.Size = new System.Drawing.Size(64, 18);
            this.ll_cancelUsrAdd.TabIndex = 8;
            this.ll_cancelUsrAdd.TabStop = true;
            this.ll_cancelUsrAdd.Text = "Cancel";
            this.ll_cancelUsrAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_cancelUsrAdd_LinkClicked);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.LightBlue;
            this.btn_AddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_AddUser.Location = new System.Drawing.Point(6, 287);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(84, 37);
            this.btn_AddUser.TabIndex = 7;
            this.btn_AddUser.Text = "Add";
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // lb_isUsrActive
            // 
            this.lb_isUsrActive.AutoSize = true;
            this.lb_isUsrActive.Location = new System.Drawing.Point(83, 198);
            this.lb_isUsrActive.Name = "lb_isUsrActive";
            this.lb_isUsrActive.Size = new System.Drawing.Size(48, 15);
            this.lb_isUsrActive.TabIndex = 6;
            this.lb_isUsrActive.Text = "Active ?";
            // 
            // cb_isUsrActive
            // 
            this.cb_isUsrActive.AutoSize = true;
            this.cb_isUsrActive.Location = new System.Drawing.Point(190, 197);
            this.cb_isUsrActive.Name = "cb_isUsrActive";
            this.cb_isUsrActive.Size = new System.Drawing.Size(83, 19);
            this.cb_isUsrActive.TabIndex = 5;
            this.cb_isUsrActive.Text = "checkBox1";
            this.cb_isUsrActive.UseVisualStyleBackColor = true;
            // 
            // tb_userPass
            // 
            this.tb_userPass.Location = new System.Drawing.Point(190, 138);
            this.tb_userPass.Name = "tb_userPass";
            this.tb_userPass.Size = new System.Drawing.Size(277, 23);
            this.tb_userPass.TabIndex = 4;
            // 
            // tb_usrName
            // 
            this.tb_usrName.Location = new System.Drawing.Point(190, 52);
            this.tb_usrName.Name = "tb_usrName";
            this.tb_usrName.Size = new System.Drawing.Size(277, 23);
            this.tb_usrName.TabIndex = 3;
            // 
            // lb_usrPass
            // 
            this.lb_usrPass.AutoSize = true;
            this.lb_usrPass.Location = new System.Drawing.Point(83, 141);
            this.lb_usrPass.Name = "lb_usrPass";
            this.lb_usrPass.Size = new System.Drawing.Size(57, 15);
            this.lb_usrPass.TabIndex = 2;
            this.lb_usrPass.Text = "Password";
            // 
            // lb_usrName
            // 
            this.lb_usrName.AutoSize = true;
            this.lb_usrName.Location = new System.Drawing.Point(83, 55);
            this.lb_usrName.Name = "lb_usrName";
            this.lb_usrName.Size = new System.Drawing.Size(65, 15);
            this.lb_usrName.TabIndex = 1;
            this.lb_usrName.Text = "User Name";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 354);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_isUsrActive;
        private System.Windows.Forms.CheckBox cb_isUsrActive;
        private System.Windows.Forms.TextBox tb_userPass;
        private System.Windows.Forms.TextBox tb_usrName;
        private System.Windows.Forms.Label lb_usrPass;
        private System.Windows.Forms.Label lb_usrName;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.LinkLabel ll_cancelUsrAdd;
    }
}