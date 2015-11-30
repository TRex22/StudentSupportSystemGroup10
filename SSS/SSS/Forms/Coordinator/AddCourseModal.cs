using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Coordinator
{
    public partial class AddCourseModal : Form
    {
        public AddCourseModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            courseTableAdapter1.Insert(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null && !textBox1.Text.Equals(""))
            {
                button1.Enabled = true;
            }
        }
    }
}
