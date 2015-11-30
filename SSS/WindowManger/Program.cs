using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using SSS_Windows_Forms;
using SSS_Windows_Forms.Forms;
using SSS_Materials_Design_Forms;
using System.Diagnostics;
using System.Threading;
using SSS_Library.ProcessHandler;

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
            HandleTypeOfWindowSystem();
        }

        private static void ShowSplashScreen()
        {
            //Display splash screen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            splashScreen.ShowDialog();
        }

        /// <summary>
        /// 4 exit codes:
        /// 
        /// 0 is clean exit
        /// 1 is move to metro
        /// 2 is move to forms
        /// 3 is failed process upstart
        /// null is unspecified error
        /// </summary>
        private static void HandleTypeOfWindowSystem()
        {
            ShowSplashScreen();
            int? result = null;

            while (result != 0 || result == 3)
            {
                if (result == null)
                {
                    result = ProcessHandler.StartProcess("SSS_Windows_Forms.exe");
                }
                else if (result == 1)
                {
                    result = ProcessHandler.StartProcess("SSS_Materials_Design_Forms.exe");
                }
                else if (result == 2)
                {
                    result = ProcessHandler.StartProcess("SSS_Windows_Forms.exe");
                }

                if (result == 0)
                {
                    Application.Exit();
                    Environment.Exit(0);//for extreme prejudice 
                }
            }
        }  
    }
}
