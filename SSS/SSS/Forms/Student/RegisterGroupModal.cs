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

namespace SSS
{
    public partial class RegisterGroupModal : Form
    {
        private readonly int _userId;
        private readonly Student _studentParent;

        public RegisterGroupModal(int userid, Student parentStudent)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
            _userId = userid;
            _studentParent = parentStudent;
        }

        private void RegisterGroupModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.GROUP_AGGREGATE' table. You can move, or remove it, as needed.
            this.gROUP_AGGREGATETableAdapter.Fill(this.iS2G10_DBSSSDataSet.GROUP_AGGREGATE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //hack because the row index corresponds to a groupid
                //TODO fix
                gROUPAGGREGATEBindingSource.Position = e.RowIndex;
                var groupAggregateDt = gROUP_AGGREGATETableAdapter.GetData();
                var groupRow = groupAggregateDt.Rows[e.RowIndex];
                int groupId = (int)groupRow.ItemArray[4]; //will be the int. group_id is 4th item
                RegisterForGroup(_userId, groupId);
                _studentParent.joinGroupToolStripMenuItem.Enabled = false;
                _studentParent._registerGroupModal.Hide();
                _studentParent._studentDashboardModal.Show();
            }
        }

        private void RegisterForGroup(int userId, int groupId)
        {
            var studentData = studentTableAdapter1.GetData().FindBystudent_id(userId);
            studentData.group_id = groupId;
            int result = studentTableAdapter1.Update(studentData);
            //TODO check result
            MessageBox.Show(Resources.UpdateStudentProfileModal_submitButton_Click_Profile_Update_Successful_, Resources.UpdateStudentProfileModal_submitButton_Click_Profile_Update_Successful_);

        }
    }
}
