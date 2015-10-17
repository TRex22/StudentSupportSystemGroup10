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
using SSS_Library;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Materials_Design_Forms
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : MetroWindow
    {
        //TODO move db stuff into library
        //database stuff
        private readonly STUDENTTableAdapter _studentTableAdapter;
        private readonly IS2G10_DBSSSDataSet.STUDENTRow _studentData;

        public Student(int userId)
        {
            _studentTableAdapter = new STUDENTTableAdapter { ClearBeforeFill = true };
            InitializeComponent();
            CreateTimer();

            _studentData = _studentTableAdapter.GetData().FindBystudent_id(userId);
            LblStudentName.Content = String.Format("{0} {1} {2}", _studentData.student_firstname, _studentData.student_lastname, userId);
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
            LblDate.Content = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Student1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
