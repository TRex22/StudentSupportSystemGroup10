using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class SearchActivitiesModal : Form
    {
        private readonly int _coordinatorId;
        private readonly int _tutorId;
        private readonly bool _isTutor = false;
        private int _id = 0;

        public SearchActivitiesModal(int coordinatorId, int? tutorId)
        {
            _coordinatorId = coordinatorId;
            if (tutorId != null)
            {
                _isTutor = true;
                _tutorId = (int)tutorId;
            }

            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return id and next window
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            button1.Enabled = true;
        }

        private void SearchActivitiesModal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            List<IS2G10_DBSSSDataSet.ACTIVITY_FULL_DATARow> data = new List<IS2G10_DBSSSDataSet.ACTIVITY_FULL_DATARow>();
            if (_isTutor)
                data = activitY_FULL_DATATableAdapter1.GetData(_coordinatorId).Where(m => m.tutor_id == _tutorId).ToList();
            else
                data = activitY_FULL_DATATableAdapter1.GetData(_coordinatorId).ToList();

            var convData = new List<IS2G10_DBSSSDataSet.STUDENT_ACTIVITYRow>();

            foreach (var d in data)
            {
                IS2G10_DBSSSDataSet.STUDENT_ACTIVITYRow conv = null;
                conv.student_activity_id = d.student_activity_id;
                conv.student_activity_description = d.student_activity_description;
                conv.student_activity_name = d.student_activity_name;
                conv.student_activity_pointvalue = d.student_activity_pointvalue;
                conv.student_activity_week = d.student_activity_week;
                convData.Add(conv);
            }

            dataGridView1.DataSource = convData;
            _id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
        }
    }
}
