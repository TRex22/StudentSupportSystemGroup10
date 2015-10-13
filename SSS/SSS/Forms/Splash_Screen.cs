using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace SSS
{
    public partial class SplashScreen : Form
    {
        private static System.Timers.Timer _timer;

        public SplashScreen()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer {Interval = 5000};
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            _timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //super neat trick
            if (this.IsHandleCreated)
                this.Invoke((MethodInvoker)Close);
        }
    }
}
