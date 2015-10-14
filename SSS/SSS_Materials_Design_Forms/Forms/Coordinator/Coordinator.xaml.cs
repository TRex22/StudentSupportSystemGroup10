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
    /// Interaction logic for Coordinator.xaml
    /// </summary>
    public partial class Coordinator : MetroWindow
    {
        //TODO move into library
        //database stuff
        private readonly SSS_COORDINATORTableAdapter _sssCoordinatorTableAdapter;
        private readonly IS2G10_DBSSSDataSet.SSS_COORDINATORRow _coordinatorData;

        public Coordinator(int userId)
        {
            _sssCoordinatorTableAdapter = new SSS_COORDINATORTableAdapter { ClearBeforeFill = true };
            InitializeComponent();
            CreateTimer();

            _coordinatorData = _sssCoordinatorTableAdapter.GetData().FindBycoordinator_id(userId);
            lblCoordinatorName.Content = String.Format("{0} {1} {2}", _coordinatorData.coordinator_firstname, _coordinatorData.coordinator_lastname, userId);
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

        private void Coordinator1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
