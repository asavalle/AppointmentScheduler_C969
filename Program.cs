using AppointmentScheduler_C969.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler_C969
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login login = new login();

            //Creates new dashboard after successful login and allows for a loop of logins after logout of dashboard
            // until the Cancel button is clicked on login screen.
            while(!login.cancelClicked)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Dashboard dash = new Dashboard();
                    Application.Run(dash);
                }               
            }
            Application.Exit();
            
           
            
            
            
        }
    }
}
