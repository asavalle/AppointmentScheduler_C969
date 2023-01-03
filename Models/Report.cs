using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AppointmentScheduler_C969.Models
{
    class Report
    {
        enum Month
        {
            January,    //0
            Febuary,    //1
            March,      //2
            April,      //3
            May,        //4
            June,       //5
            July,       //6
            August,     //7
            September,  //8
            October,    //9
            November,   //10
            December    //11
        }
        

        Dictionary<string, Object> months = new Dictionary<string, object>();
        Dictionary<string, int> AptTypeCounts = new Dictionary< string, int>();
        private static string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        private static string filePath = $@"c:\Users\{UserName.Split('\\')[1].ToString()}\Downloads\";


        public static void CreateFile(List<string> ReportList)
        {

            SaveFileDialog saveDiag = new SaveFileDialog();
            saveDiag.DefaultExt = "*.txt";
            saveDiag.Filter = "txt files (*.txt)|*.txt";
            saveDiag.Title = "Save Report";

            DirectoryInfo di;
            string path =filePath;
                                
            if (saveDiag.ShowDialog() == DialogResult.OK)
            {
                path = saveDiag.FileName;
                di = new DirectoryInfo(path);
            }
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                    foreach (string s in ReportList)
                    {

                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
     
        }

       
    }
}
