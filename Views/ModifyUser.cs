using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class ModifyUser : Form
    {
        
        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            //fill in fields with selected user info.
            User SelectedUser = new User();
            var selectedUserId = User.CurrentUserId; //get selected User row's userId.
            DataTable ut = User.GetAllUserInfo(selectedUserId); //grab all the selected user's information.
            //create a filtered list of just the selected user's information
            var filtered = from usr in ut.AsEnumerable()
                         where usr.Field<int>("userId") == selectedUserId
                         select new
                         {
                             userName = usr.Field<string>("userName"),
                             password = usr.Field<string>("password"),
                             active = usr.Field<sbyte>("active"),
                             
                         };

            //iterate through each field of the filtered user information and assign the values to form.
            foreach (var item in filtered)
            {
                var isChecked = (item.active == 1) ? true : false;

                tb_modUsrName.Text = item.userName;
                tb_modUsrPass.Text = item.password  ;
                cb_modActive.Checked = isChecked;
               
            }


        }

        private void btn_modEditUser_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.gb_modUser.Controls)
            {
                if (!c.Enabled)
                {
                    c.Enabled = true;
                }
                btn_modSaveUser.Visible = true;
                btn_updatePass.Visible = true;
                
            }
        }

        private void ll_modCancelUsr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_modSaveUser_Click(object sender, EventArgs e)
        {
            User updatedUserInfo = new User(); //create temporary User object

            var selectedUser = User.CurrentUserId; //get selected User row's userId.
            DataTable ut = User.GetAllUserInfo(selectedUser); //grab all the selected user's information.
            //create a filtered list of just the selected user's information
            var sorted = from usr in ut.AsEnumerable()
                         where usr.Field<int>("userId") == selectedUser
                         select new
                         {
                             userId = usr.Field<int>("userId"),
                             userName = usr.Field<string>("userName"),
                             password = usr.Field<string>("password"),
                             active = usr.Field<sbyte>("active"),
                             createDate = usr.Field<DateTime>("createDate"),
                             createdBy = usr.Field<string>("createdBy"),
                             lastUpdate = usr.Field<DateTime>("lastUpdate"),
                             lastUpdateBy = usr.Field<string>("lastUpdateBy")
                         };

            //iterate through each field of the filtered user information and assign the values to the temporary User object.
            foreach (var item in sorted)
            {
                var isChecked = (cb_modActive.Checked == true) ? 1 : 0;
                updatedUserInfo.userID = item.userId;
                updatedUserInfo.userName = tb_modUsrName.Text;
                updatedUserInfo.password = tb_usrNewPass.Text;
                updatedUserInfo.active = isChecked;
                updatedUserInfo.createDate = item.createDate;
                updatedUserInfo.createdBy = item.createdBy;
                updatedUserInfo.lastUpdate = DateTime.Now;
                updatedUserInfo.lastUpdateBy = DataAccess.LoggedInUser;
            }

            //pass temporary User object to the controller.
            UsersController.ModifyUser(updatedUserInfo);
            this.Close();
        }

        private void btn_updatePass_Click(object sender, EventArgs e)
        {
            lbl_newPass.Visible = true;
            tb_usrNewPass.Visible = true;
        }

        private void tb_usrNewPass_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            if (tb_usrNewPass.Text.Length == 0 || tb_usrNewPass.Text == " ")
            {
                error = "Password cannot be blank. Please enter a password.";
                e.Cancel = true;
            }
            errPr_modUser.SetError((Control)sender, error);
        }
    }
}
