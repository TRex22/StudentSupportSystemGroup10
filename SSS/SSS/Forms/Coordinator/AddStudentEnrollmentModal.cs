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
    public partial class AddStudentEnrollmentModal : Form
    {
        private string _courseName;
        private IS2G10_DBSSSDataSet.COURSERow _course;

        private double class_mark;
        private double exam_mark;
        private double year_mark;

        private readonly int _studentId;

        public AddStudentEnrollmentModal(int studentId)
        {
            _studentId = studentId;
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            class_markTxtbox.Enabled = false;
            exam_markTxtBox.Enabled = false;
            year_markTxtBox.Enabled = false;
            button1.Enabled = false;

            PopulateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class_mark = Convert.ToDouble(class_markTxtbox.Text);
            exam_mark = Convert.ToDouble(exam_markTxtBox.Text);
            year_mark = Convert.ToDouble(year_markTxtBox.Text);

            enrollmentTableAdapter1.Insert(_course.course_id, _studentId, class_mark, exam_mark, year_mark);

            MessageBox.Show(SSS_Library.Properties.Resources.AddEnrollmentSuccess, SSS_Library.Properties.Resources.AddEnrollmentSuccess);
            ClearForm();
        }

        private void PopulateData()
        {
            var courses = courseTableAdapter1.GetData();
            foreach (var c in courses)
            {
                comboBox1.Items.Add(c.course_name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _courseName = comboBox1.SelectedItem + "";
            _course = courseTableAdapter1.GetData().FirstOrDefault(m => m.course_name.Equals(_courseName));

            class_markTxtbox.Enabled = true;
            exam_markTxtBox.Enabled = true;
            year_markTxtBox.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coordinator coordinator = (SSS_Windows_Forms.Forms.Coordinator.Coordinator)Application.OpenForms["Coordinator"];
            this.Hide();
            coordinator._registerStudentModal.Show();
            ClearForm();
        }

        private void ClearForm()
        {
            comboBox1.SelectedIndex = -1;
            class_markTxtbox.Enabled = false;
            class_markTxtbox.Text = "";
            exam_markTxtBox.Enabled = false;
            exam_markTxtBox.Text = "";
            year_markTxtBox.Enabled = false;
            year_markTxtBox.Text = "";
            button1.Enabled = false;
        }
    }
}
