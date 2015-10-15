using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SSS_Library.WindowHandler
{
    public class WpfWindowCloseHandler
    {
        public void CloseWindow(string windowName)
        {
            Window win = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.Name == windowName);
            win.Close();
        }
    }
}
