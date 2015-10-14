using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using SSS;
using SSS.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Materials_Design_Forms
{
    /// <summary>
    /// Interaction logic for Tutor.xaml
    /// </summary>
    public partial class Tutor : MetroWindow
    {
        //TODO move into library
        //database stuff
        private readonly TUTORTableAdapter _tutorTableAdapter;
        private readonly IS2G10_DBSSSDataSet.TUTORRow _tutorData;

        public Tutor(int userId)
        {
            _tutorTableAdapter = new TUTORTableAdapter { ClearBeforeFill = true };
            InitializeComponent();
            CreateTimer();

            _tutorData = _tutorTableAdapter.GetData().FindBytutor_id(userId);
            lblTutorName.Content = String.Format("{0} {1} {2}", _tutorData.tutor_firstname, _tutorData.tutor_lastname, userId);
        }

        private void CreateTimer()
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(tmrSecond_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblDate.Content = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
