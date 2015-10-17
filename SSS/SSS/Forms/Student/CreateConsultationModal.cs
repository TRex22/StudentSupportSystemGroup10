using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library.WindowHandler;

namespace SSS_Windows_Forms.Forms.Student
{
    public partial class CreateConsultationModal : Form
    {
        private readonly int _userId;
        private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENTRow _studentData;
        private readonly SSS_Library.IS2G10_DBSSSDataSet.TUTORDataTable _tutorDataTable;

        public CreateConsultationModal(int userId, SSS_Library.IS2G10_DBSSSDataSet.STUDENTRow studentData)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _userId = userId;
            _studentData = studentData;
            _tutorDataTable = this.tutorTableAdapter1.GetData();

            PopulateData();

            dateComboBox.Enabled = false;
            timeComboBox.Enabled = false;
            BookButton.Enabled = false;
        }

        private void PopulateData()
        {
            foreach (var tutor in _tutorDataTable)
            {
                var tutorName = String.Format("{0} {1}", tutor.tutor_firstname, tutor.tutor_lastname);
                ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                {
                    Text = tutorName,
                    Value = tutor.tutor_id
                };
                
                tutorComboBox.Items.Add(item);
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            var tutorComboboxItem = tutorComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;
            var selectedDateComboItem = dateComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;
            var selectedTimeComboItem = timeComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;

            if (tutorComboboxItem != null)
                this.consultationTableAdapter1.Insert(_studentData.coordinator_id, Convert.ToInt32(tutorComboboxItem.Value), _userId, detailsTextBox.Text, null, null, null);
            MessageBox.Show(SSS_Library.Properties.Resources.CreateConsultationSuccess, SSS_Library.Properties.Resources.CreateConsultationSuccess);

            ClearForm();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tutorComboboxItem = tutorComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;

            if (tutorComboboxItem != null)
            {
                var dateDataTable = tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1.GetData(Convert.ToInt32(tutorComboboxItem.Value));
                foreach (var date in dateDataTable)
                {
                    ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                    {
                        Text = date.date_free.ToLongDateString(),
                        Value = date.date_free.ToLongDateString()
                    };

                    dateComboBox.Items.Add(item);
                }
                dateComboBox.Enabled = true;
            }
            else
            {
                ClearForm();
            }
        }

        private void ClearForm()
        {
            tutorComboBox.SelectedItem = -1;

            dateComboBox.Enabled = false;
            timeComboBox.Enabled = false;
            BookButton.Enabled = false;
            detailsTextBox.Text = "";
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tutorComboboxItem = tutorComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;
            var selectedDateComboItem = dateComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;

            if (tutorComboboxItem != null)
            {
                var dateDataTable = tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1.GetData(Convert.ToInt32(tutorComboboxItem.Value));
                foreach (var date in dateDataTable)
                {
                    if (date.available_day.Equals(""+selectedDateComboItem))
                    {
                        ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                        {
                            Text = "" + date.available_time,
                            Value = date.available_time
                        };
                        timeComboBox.Items.Add(item);
                    }
                }
                timeComboBox.Enabled = true;
            }
            else
            {
                ClearForm();
            }
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookButton.Enabled = true;
        }
    }
}
