using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ShowSplashScreen();
            var login = new Login();
            Application.Run(login);
        }

        private static void ShowSplashScreen()
        {
            //Display splash screen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();
            Thread.Sleep(5000);//5 sec
            splashScreen.Hide();
            //then destory it
            splashScreen.Dispose();
        }
    }
}
