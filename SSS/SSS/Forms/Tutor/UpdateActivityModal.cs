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
    public partial class UpdateActivityModal : Form
    {
        private readonly int _coordinatorId;
        private readonly int _tutorId;
        private readonly bool _isTutor = false;
        private int _id = 0;

        public UpdateActivityModal(int coordinatorId, int? tutorId)
        {
            _coordinatorId = coordinatorId;
            if (tutorId != null)
            {
                _isTutor = true;
                _tutorId = (int)tutorId;
            }

            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var activity = activitY_FULL_DATATableAdapter1.GetData(_coordinatorId).FirstOrDefault(m => m.student_activity_id == _id);
            DisplayActivityInformation(activity);
        }

        private void DisplayActivityInformation(IS2G10_DBSSSDataSet.ACTIVITY_FULL_DATARow activity)
        {
            throw new NotImplementedException();
        }

        private void UpdateActivityModal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            if (_isTutor)
                dataGridView1.DataSource = activitY_FULL_DATATableAdapter1.GetData(_coordinatorId).Where(m => m.tutor_id == _tutorId).ToList();
            else
                dataGridView1.DataSource = activitY_FULL_DATATableAdapter1.GetData(_coordinatorId);
            _id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
