using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using SSS_Windows_Forms;
using SSS_Windows_Forms.Forms;
using SSS_Materials_Design_Forms;

namespace WindowManger
{
    /// <summary>
    /// Sushi is the window manager which deals with both the windows forms and the wpf stuff.
    /// It handles the main thread and all that pain
    /// Beware Dragons Be Here
    /// </summary>
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
            var login = new SSS_Windows_Forms.Forms.Login();
            var metroLogin = new SSS_Materials_Design_Forms.Forms.Login();

            Application.Run(login);
        }

        private static void ShowSplashScreen()
        {
            //Display splash screen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            splashScreen.ShowDialog();
        }

        /*private void OpenWpf()
        {
            var metroLogin = new SSS_Materials_Design_Forms.Forms.Login();
            WindowInteropHelper wih = new WindowInteropHelper(this);
            wih.Owner = metroLogin.Handle;
            metroLogin.ShowDialog();
        }*/


    }
}
