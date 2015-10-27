using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library.Properties;
using SSS_Library.WindowHandler;

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class SearchStudentModal : Form
    {
        private enum searches
        {
            None = 0,
            UpdateStudent = 1,
            UpdateConsultation = 2
        };

        private readonly SSS_Library.IS2G10_DBSSSDataSet.GROUPDataTable _group;

        private readonly int _coordinatorId;
        private readonly bool _isUpdateStudent = false;
        private readonly bool _isUpdateStudentConsultation = false;
        private int _groupId;

        public SearchStudentModal(int coordinatorId, string typeOfSearch)
        {
            searches search = (searches)System.Enum.Parse(typeof(searches), typeOfSearch);

            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            checkBox1.Checked = false;

            if ((int)search == 1)
            {
                this.label1.Text = "Find Student To Update";
                _isUpdateStudent = true;
            }
            else if ((int)search == 2)
            {
                this.label1.Text = "Find Student To Update Consultation";
                _isUpdateStudentConsultation = true;
            }

            _coordinatorId = coordinatorId;
            _group = groupTableAdapter1.GetData();
            _groupId = PopulateGroupComboBox();

        }

        //TODO if null
        public int PopulateGroupComboBox()
        {
            for (int i = 0; i < _group.Count; i++)
            {
                ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                {
                    Text = String.Format("{0}", _group.Rows[i].ItemArray[1]),
                    Value = _group.Rows[i].ItemArray[0]
                };

                groupComboBox.Items.Add(item);
            }
            groupComboBox.SelectedIndex = 0;
            return Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
        }

        private void SearchStudentModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sEARCH_STUDENTTableAdapter.Fill(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            SSS_Library.IS2G10_DBSSSDataSet.SEARCH_STUDENTRow student = sEARCH_STUDENTTableAdapter.GetData(_coordinatorId).FindBystudent_id(studentId);

            if (!_isUpdateStudent || !_isUpdateStudentConsultation)
            {
                DisplayStudentInformation(student);
            }
            else if (_isUpdateStudent)
            {
                Coordinator coordinator = (Coordinator)Application.OpenForms["Coordinator"];
                var updateStudentProfileModalModal = new UpdateStudentProfileModal(studentId);
                coordinator.SetModal(updateStudentProfileModalModal);
                this.Hide();
                updateStudentProfileModalModal.Show();
            }
            else if (_isUpdateStudentConsultation)
            {
                //todo
                throw new NotImplementedException();
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _groupId = Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
            this.sEARCH_STUDENTTableAdapter.FillGroupSearch(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId, _groupId);
        }

        private void DisplayStudentInformation(SSS_Library.IS2G10_DBSSSDataSet.SEARCH_STUDENTRow student)
        {
            var message = String.Format("Student Name: {0} {1}\n" +
                                                                 "Student Id: {2}\n" +
                                                                 "Student's ID or Passport: {3}\n" +
                                                                 "Date Of Birth: {4}\n" +
                                                                 "Email: {5}\n" +
                                                                 "Mobile Number: {6}\n" +
                                                                 "Year Of Study: {7}\n" +
                                                                 "Degree Programme: {8}\n" +
                                                                 "Student Status: {9}\n" +
                                                                 "Student Points: {10}",
                                                                 student.student_firstname,
                                                                 student.student_lastname,
                                                                 student.student_id,
                                                                 student.student_id_passport,
                                                                 student.student_dateofbirth.Date.ToShortDateString(),
                                                                 student.student_emailaddress,
                                                                 student.student_mobilenumber,
                                                                 student.student_yearofstudy,
                                                                 student.student_degreeprogramme,
                                                                 student.student_status,
                                                                 student.student_points);
            MessageBox.Show(message, Resources.SearchStudentMessageBoxHeading);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if true by group disable rest
            if (checkBox1.Checked)
            {
                groupComboBox.Enabled = true;
                groupBox2.Enabled = false;
                _groupId = Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
                this.sEARCH_STUDENTTableAdapter.FillGroupSearch(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId, _groupId);

            }
            else
            {
                groupBox2.Enabled = true;
                this.sEARCH_STUDENTTableAdapter.Fill(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var studentId = Convert.ToInt32(studentIDtextBox1.Text);
            this.sEARCH_STUDENTTableAdapter.FillById(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId, studentId);
        }
    }
}
