using AppointmentScheduler_C969.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppointmentScheduler_C969.Controllers
{
    class UsersController
    {

        public static void CreateUser(User user)
        {
            User.InsertUserRecord(user);
        }

        public static void ModifyUser()
        {
            User.UpdateUserRecord();
        }

        public static void DeleteUser()
        {
            User.DeleteUserRecord();
        }
    }
}
