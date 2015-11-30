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

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class AssignTutor : Form
    {
        private IS2G10_DBSSSDataSet.GROUPDataTable _groups;
        private IS2G10_DBSSSDataSet.TUTORDataTable _tutors;
        
        public AssignTutor(int coordinatorId)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            button1.Enabled = false;
            listView2.Enabled = false;
            listView1.View = View.Details;
            listView2.View = View.Details;

            PopulateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateData()
        {
            _groups = groupTableAdapter1.GetData();
            _tutors = tutorTableAdapter1.GetData();
        }
    }
}
