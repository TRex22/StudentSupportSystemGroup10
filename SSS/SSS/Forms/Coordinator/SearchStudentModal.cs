using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS.Properties;
using SSS_Library.WindowHandler;

namespace SSS.Forms.Coordinator
{
    public partial class SearchStudentModal : Form
    {
        private readonly IS2G10_DBSSSDataSet.GROUPDataTable _group;

        private readonly int _coordinatorId;
        private readonly bool _isUpdateStudent;
        private int _groupId;

        public SearchStudentModal(int coordintaorId, bool isUpdateStudent)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _coordinatorId = coordintaorId;
            _isUpdateStudent = isUpdateStudent;
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
            return Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem)?.Value.ToString());
        }

        private void SearchStudentModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sEARCH_STUDENTTableAdapter.Fill(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId, _groupId);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            IS2G10_DBSSSDataSet.SEARCH_STUDENTRow student = sEARCH_STUDENTTableAdapter.GetData(_coordinatorId, _groupId).FindBystudent_id(studentId);

            if (!_isUpdateStudent)
            {
                displayStudentInformation(student);
            }
            else
            {
                SSS.Coordinator coordinator = (SSS.Coordinator)Application.OpenForms["Coordinator"];
                var updateStudentProfileModalModal = new UpdateStudentProfileModal(studentId);
                coordinator.SetModal(updateStudentProfileModalModal);
                this.Hide();
                updateStudentProfileModalModal.Show();
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _groupId = Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem)?.Value.ToString());
            this.sEARCH_STUDENTTableAdapter.Fill(this.iS2G10_DBSSSDataSet.SEARCH_STUDENT, _coordinatorId, _groupId);
        }

        private void displayStudentInformation(IS2G10_DBSSSDataSet.SEARCH_STUDENTRow student)
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
    }
}
