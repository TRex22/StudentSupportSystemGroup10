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

namespace SSS
{

    public partial class UpdateStudentAttendanceModal : Form
    {
        private readonly IS2G10_DBSSSDataSet.TUTOR_SESSION_GROUPDataTable _tutorSessionGroup;
        private readonly IS2G10_DBSSSDataSet.STUDENT_ACTIVITYDataTable _studentActivity;
        private readonly int _tutorId;
        private int _groupId;
        private int _studentActivityId;

        public UpdateStudentAttendanceModal(int tutorId)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
            _tutorId = tutorId;

            _tutorSessionGroup = tutoR_SESSION_GROUPTableAdapter1.GetData(_tutorId);
            _studentActivity = studenT_ACTIVITYTableAdapter1.GetData();

            _groupId = PopulateGroupComboBox();
            _studentActivityId = PopulateStudentActivityComboBox();

        }

        //TODO if null
        private int PopulateStudentActivityComboBox()
        {
            for (int i = 0; i < _studentActivity.Count; i++)
            {
                ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                {
                    Text = String.Format("{0}", _studentActivity.Rows[i].ItemArray[1]),
                    Value = _studentActivity.Rows[i].ItemArray[0]
                };

                activityComboBox.Items.Add(item);
            }
            activityComboBox.SelectedIndex = 0;
            return Convert.ToInt32((activityComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
        }

        //TODO if null
        public int PopulateGroupComboBox()
        {
            for (int i = 0; i < _tutorSessionGroup.Count; i++)
            {
                ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                {
                    Text = String.Format("{0}", _tutorSessionGroup.Rows[i].ItemArray[1]),
                    Value = _tutorSessionGroup.Rows[i].ItemArray[0]
                };

                groupComboBox.Items.Add(item);
            }
            groupComboBox.SelectedIndex = 0;
            return Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
        }

        private void UpdateStudentAttendanceModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet2.UPDATE_STUDENT_ATTENDANCE' table. You can move, or remove it, as needed.
            this.uPDATE_STUDENT_ATTENDANCETableAdapter.Fill(this.iS2G10_DBSSSDataSet2.UPDATE_STUDENT_ATTENDANCE, _groupId, _studentActivityId);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            IS2G10_DBSSSDataSet.ATTENDANCERow attendanceRow = aTTENDANCETableAdapter.GetData().FindBystudent_idstudent_activity_id(studentId, _studentActivityId);
            attendanceRow.student_arrived = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].EditedFormattedValue);
            aTTENDANCETableAdapter.Update(attendanceRow);
            MessageBox.Show(Resources.UpdateStudentAttendanceSuccess, Resources.UpdateStudentAttendanceSuccess);
        }

        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _studentActivityId = Convert.ToInt32((activityComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
            this.uPDATE_STUDENT_ATTENDANCETableAdapter.Fill(this.iS2G10_DBSSSDataSet2.UPDATE_STUDENT_ATTENDANCE, _groupId, _studentActivityId);
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _groupId = Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
            this.uPDATE_STUDENT_ATTENDANCETableAdapter.Fill(this.iS2G10_DBSSSDataSet2.UPDATE_STUDENT_ATTENDANCE, _groupId, _studentActivityId);
        }
    }
}
