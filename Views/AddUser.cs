﻿using AppointmentScheduler_C969.Controllers;
using AppointmentScheduler_C969.Models;
using System;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Views
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {

            int activeStatus;
            if (cb_isUsrActive.Checked)
            {
                activeStatus = 1;

            }
            else
            {
                activeStatus = 0;
            }
            try
            {
                User newUsr = new User(tb_usrName.Text, tb_userPass.Text, activeStatus, DateTime.Now, DataAccess.LoggedInUser, DateTime.Now, DataAccess.LoggedInUser);


                UsersController.CreateUser(newUsr);
                MessageBox.Show($"New User {newUsr.userName} was added.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in the AddUser: " + ex.Message);
            }

        }

        private void ll_cancelUsrAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
