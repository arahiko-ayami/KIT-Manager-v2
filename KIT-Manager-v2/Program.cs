using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIT_Manager_v2.UI;


namespace KIT_Manager_v2
{
    static class Program
    {
        public static string ApplicationName = "KIT Manager";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
        }
    }
}