using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace SSS_Library.WindowHandler
{
    public class WpfFormsConverter
    {
        /*[DllImport("user32.dll")]

        private static extern int SetWindowLongPtr(HandleRef hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// sets the owner of a System.Windows.Forms.Form to a System.Windows.Window
        /// </summary>
        /// <param name="form"></param>
        /// <param name="owner"></param>
        public static void SetOwner(System.Windows.Forms.Form form, System.Windows.Window owner)
        {
            /*WindowInteropHelper helper = new WindowInteropHelper(owner);
            SetWindowLongPtr(new HandleRef(form, form.Handle), -8, helper.Handle.ToInt32());#1#
        }*/
    }
}
