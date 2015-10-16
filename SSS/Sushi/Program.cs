using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using SSS_Materials_Design_Forms;
using Application = System.Windows.Forms.Application;
using SplashScreen = SSS_Windows_Forms.SplashScreen;

namespace Sushi
{
    /// <summary>
    /// The main window manager for Student Support System
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
            var app = new App();
            app.Run();
            //Application.Run(login);
        }

        private static void ShowSplashScreen()
        {
            //Display splash screen
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            splashScreen.ShowDialog();
        }

        //This is what chooses old forms or new metro design
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(HandleRef hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// sets the owner of a System.Windows.Forms.Form to a System.Windows.Window
        /// </summary>
        /// <param name="form"></param>
        /// <param name="owner"></param>
        public static void SetOwner(System.Windows.Forms.Form form, System.Windows.Window owner)
        {
            WindowInteropHelper helper = new WindowInteropHelper(owner);
            SetWindowLong(new HandleRef(form, form.Handle), -8, helper.Handle.ToInt32());
        }
    }
}
