using AppointmentScheduler_C969.Models;

namespace AppointmentScheduler_C969.Controllers
{
    class UsersController
    {

        public static void CreateUser(User user)
        {
            User.InsertUserRecord(user);
        }

        public static void ModifyUser(User user)
        {
            User.UpdateUserRecord(user);
        }

        public static void DeleteUser(int userId)
        {
            User.DeleteUserRecord(userId);
        }
    }
}
