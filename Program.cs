using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMtuto
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashscreen splashScreen = new splashscreen();
            splashScreen.Show();

            Application.DoEvents();
            // Wait for a few seconds (you can adjust the time as needed)
            System.Threading.Thread.Sleep(5000);
            // Close splash screen
            splashScreen.Close();

            Application.Run(new Login());
        }
    }
}
