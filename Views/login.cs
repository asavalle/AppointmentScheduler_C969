using AppointmentScheduler_C969.Models;
using System;
using System.Windows.Forms;

namespace AppointmentScheduler_C969
{
    public partial class login : Form
    {
        public bool cancelClicked = false;
        public login()
        {
            InitializeComponent();
            lb_userName.Select(); //removes focus from TextBox so placeholder text can be revealed.
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string uname = tb_UserName.Text.ToString();
            string password = tb_userPwd.Text.ToString();
            DataAccess.Login(uname, password);
            if (DataAccess.loginSuccessful)
            {
                DialogResult = DialogResult.OK;
                tb_UserName.Text = "";
                tb_userPwd.Text = "";
                Report.LoginLogReport();
            }
        }

        private void btn_cancelLogin_Click(object sender, EventArgs e)
        {
            cancelClicked = true;
            this.Close();
        }


    }
}
