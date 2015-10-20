using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using SSS_Library.DataServices;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;
using SSS_Library.WindowHandler;

namespace SSS_Windows_Forms.Forms.Student
{
    public partial class CreateConsultationModal : Form
    {
        private readonly int _userId;
        private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENTRow _studentData;
        private readonly SSS_Library.IS2G10_DBSSSDataSet.TUTORDataTable _tutorDataTable;
        private readonly TUTOR_AVAILABLE_TIMESTableAdapter _availableTimesTableAdapter = new TUTOR_AVAILABLE_TIMESTableAdapter();
        
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
            var selectedDateComboItem = dateComboBox.SelectedItem;
            var selectedTimeComboItem = timeComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;

            if (tutorComboboxItem != null && selectedDateComboItem != null && selectedTimeComboItem != null)
            {
                //TODO mark as time taken by consultation
                DateTime selectedDate = DateTime.ParseExact(selectedDateComboItem.ToString(), "dd MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Times selectedTime = (Times)selectedTimeComboItem.Value;

                var consultationDate = selectedDate + selectedTime.Time;
                 
                var availableTime = _availableTimesTableAdapter.GetData().FindBytutor_time_id(selectedTime.TutorTimesId);
                availableTime.booked = true;
                _availableTimesTableAdapter.Update(availableTime);

                this.consultationTableAdapter1.Insert(_studentData.coordinator_id, Convert.ToInt32(tutorComboboxItem.Value), _userId, detailsTextBox.Text, consultationDate, null, null);
                
                MessageBox.Show(SSS_Library.Properties.Resources.CreateConsultationSuccess, SSS_Library.Properties.Resources.CreateConsultationSuccess);
                ClearForm();
            }
            else
            {
                MessageBox.Show(SSS_Library.Properties.Resources.CreateConsultationFail, SSS_Library.Properties.Resources.CreateConsultationFail);
                ClearForm();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateComboBox.Items.Clear();
            dateComboBox.ResetText();
            timeComboBox.Items.Clear();
            timeComboBox.ResetText();
            timeComboBox.SelectedIndex = -1;
            dateComboBox.Enabled = false;
            timeComboBox.Enabled = false;

            var tutorComboboxItem = tutorComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;
            
            if (tutorComboboxItem != null)
            {
                var dateDataTable = tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1.GetData(Convert.ToInt32(tutorComboboxItem.Value));
                
                DateTimeCollection datesAndTimes = new DateTimeCollection(); 
                //add all unique dates
                foreach (var item in dateDataTable.OrderBy(i => i.date_free))
                {
                    var oneDate = new DateTimes { Date = item.date_free };
                    if (datesAndTimes.FindDateCollection(oneDate) != null)
                    {
                        var foundItem = datesAndTimes.FindDateCollection(oneDate);
                        var times = new Times
                        {
                            Time = item.date_free.TimeOfDay,
                            TutorTimesId = item.tutor_time_id
                        };
                        foundItem.Times.Add(times);
                    }
                    else
                    {
                        var times = new Times
                        {
                            Time = item.date_free.TimeOfDay,
                            TutorTimesId = item.tutor_time_id
                        };
                        oneDate.Times.Add(times);
                        datesAndTimes.CollectionOfDateTimes.Add(oneDate);
                    }
                }
                
                foreach (var date in datesAndTimes.CollectionOfDateTimes)
                {
                    var cmbItem = new ComboBoxHandler.ComboboxItem
                    {
                        Text = date.Date.ToLongDateString(),
                        Value = date
                    };
                    dateComboBox.Items.Add(cmbItem);
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
            dateComboBox.Items.Clear();
            dateComboBox.SelectedItem = null;
            dateComboBox.ResetText();
            timeComboBox.Items.Clear();
            timeComboBox.ResetText();
            timeComboBox.SelectedItem = null;
            tutorComboBox.SelectedItem = -1;
            dateComboBox.Enabled = false;
            dateComboBox.SelectedIndex = -1;
            timeComboBox.Enabled = false;
            timeComboBox.SelectedIndex = -1;
            BookButton.Enabled = false;
            detailsTextBox.Text = "";
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeComboBox.Items.Clear();
            timeComboBox.SelectedItem = null;
            timeComboBox.ResetText();
            timeComboBox.Enabled = false;
            var tutorComboboxItem = tutorComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;
            var selectedDateComboItem = dateComboBox.SelectedItem as ComboBoxHandler.ComboboxItem;

            if (tutorComboboxItem != null && selectedDateComboItem != null)
            {
                var times = (DateTimes)selectedDateComboItem.Value;
                foreach (var time in times.Times)
                {
                    var cmbItem = new ComboBoxHandler.ComboboxItem();
                    cmbItem.Value = time;
                    cmbItem.Text = time.Time.ToString();
                    var availableTime = _availableTimesTableAdapter.GetData().FindBytutor_time_id(time.TutorTimesId);
                    if (!availableTime.booked)
                    {
                        timeComboBox.Items.Add(cmbItem);
                    }
                }
                if (timeComboBox.Items.Count > 0)
                    timeComboBox.Enabled = true;
                else
                {
                    MessageBox.Show(SSS_Library.Properties.Resources.ConsultationFullyBookedMessage);
                    ClearForm();
                }
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
