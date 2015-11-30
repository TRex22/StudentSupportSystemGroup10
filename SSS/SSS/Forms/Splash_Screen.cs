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
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;
using Timer = System.Threading.Timer;

namespace SSS_Windows_Forms
{
    public partial class SplashScreen : Form
    {
        private static System.Timers.Timer _timer;
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.BRANDINGTableAdapter _brandingTableAdapter = new BRANDINGTableAdapter();
        private readonly SSS_Library.IS2G10_DBSSSDataSet.BRANDINGRow _branding;
        private double _timeSpec = 0;
        private Image _splashImage;
        private Icon _programIcon;
        private string _splashProgramName;
        private Color _splashColour;

        public SplashScreen()
        {
            _branding = _brandingTableAdapter.GetData().FirstOrDefault();
            BindBranding();
            InitializeComponent();
            InsertDbBranding();
            _timer = new System.Timers.Timer {Interval = _timeSpec};
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
        }

        private void InsertDbBranding()
        {
            pictureBox1.Image = _splashImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.Icon = _programIcon;
            label2.Text = _splashProgramName;
            this.ForeColor = _splashColour;
        }

        private void BindBranding()
        {
            if (_branding != null)
            {
                _timeSpec = 5000;
                _splashImage = SSS_Library.DataServices.ByteImageConverter.ConvertBytesToImage(_branding.system_logo);
                _programIcon = SSS_Library.DataServices.ByteImageConverter.ConvertBytesToIcon(_branding.program_icon);
                _splashProgramName = _branding.system_name;
                _splashColour = Color.FromName(_branding.splash_colour);
            }
            else
            {
                _timeSpec = 5000;
                _splashImage = null;
                _programIcon = null;
                _splashProgramName = "Student Support Program Default";
                _splashColour = SystemColors.Control;
            }
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
