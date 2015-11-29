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
using SSS_Library.WindowHandler;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class UpdateActivityModal : Form
    {

        private readonly IS2G10_DBSSSDataSet.STUDENT_ACTIVITYDataTable _studentActivity;
        private readonly int _coordinatorId;
        private readonly int _tutorId;
        private readonly bool _isTutor = false;
        private int _id = 0;
        private int _studentActivityId;

        public UpdateActivityModal(int coordinatorId, int? tutorId)
        {
            _coordinatorId = coordinatorId;
            if (tutorId != null)
            {
                _isTutor = true;
                _tutorId = (int)tutorId;
            }

            InitializeComponent();
            DisableControls();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
            _studentActivity = studenT_ACTIVITYTableAdapter1.GetData();
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

                comboBox1.Items.Add(item);
            }
            comboBox1.SelectedIndex = 0;
            return Convert.ToInt32((comboBox1.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _studentActivityId = Convert.ToInt32((comboBox1.SelectedItem as ComboBoxHandler.ComboboxItem).Value.ToString());
            PopulateControls();
        }

        private void PopulateControls()
        {
            var activity = studenT_ACTIVITYTableAdapter1.GetData().FindBystudent_activity_id(_studentActivityId);

            textBox1.Text = ""+activity.student_activity_id;
            textBox2.Enabled = true;
            textBox2.Text = activity.student_activity_name;
            textBox3.Enabled = true;
            textBox3.Text = ""+ activity.student_activity_pointvalue;
            textBox4.Enabled = true;
            textBox4.Text = "" + activity.student_activity_week;
            richTextBox1.Enabled = true;
            richTextBox1.Text = activity.student_activity_description;
            button1.Enabled = true;
        }

        private void DisableControls()
        {
            textBox1.Enabled = false;
            textBox1.Text = "";
            textBox2.Enabled = false;
            textBox2.Text = "";
            textBox3.Enabled = false;
            textBox3.Text = "";
            textBox4.Enabled = false;
            textBox4.Text = "";
            richTextBox1.Enabled = false;
            richTextBox1.Text = "";
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var activity = studenT_ACTIVITYTableAdapter1.GetData().FindBystudent_activity_id(_studentActivityId);
            activity.student_activity_name = textBox2.Text;
            activity.student_activity_pointvalue = Convert.ToInt32(textBox3.Text);
            activity.student_activity_week = Convert.ToInt32(textBox4.Text);
            activity.student_activity_description = richTextBox1.Text;
        }
    }
}
