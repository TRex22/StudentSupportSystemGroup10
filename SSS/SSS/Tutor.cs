using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class Tutor : Form
    {

        //global vars
        String sUser = "";
        String sPassword = "";

        public Tutor(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            sUser = sUsr;
            sPassword = sPsswrd;
        }

        private void Tutor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
