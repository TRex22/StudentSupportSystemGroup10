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
    public partial class UpdateCourseModal : Form
    {
        private string _courseName;
        private IS2G10_DBSSSDataSet.COURSERow _course;

        public UpdateCourseModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            button1.Enabled = false;
            textBox1.Enabled = false;
            PopulateData();
        }

        private void PopulateData()
        {
            var courses = courseTableAdapter1.GetData();
            foreach (var c in courses)
            {
                listBox1.Items.Add(c.course_name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            _courseName = listBox1.SelectedItem + "";
            _course = courseTableAdapter1.GetData().First(m => m.course_name.Equals(_courseName));
            textBox1.Text = _courseName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _course.course_name = textBox1.Text;
            courseTableAdapter1.Update(_course);

            button1.Enabled = false;
            textBox1.Enabled = false;
            PopulateData();
        }
    }
}
