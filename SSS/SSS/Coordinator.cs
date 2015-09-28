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
    public partial class Coordinator : Form
    {

        //global vars
        String sUser = "";
        String sPassword = "";
        public Coordinator(String sUsr, String sPsswrd)
        {
            InitializeComponent();
            sUser = sUsr;
            sPassword = sPsswrd;
            lblCoordinatorName.Text = "Gerhard Snell - " + sUser;
            tmrSecond.Start();
        }

        private void Coordinator_Load(object sender, EventArgs e)
        {

        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
          //  lblDate.Text = DateTime.Now.ToShortTimeString();
            lblDate.Text = DateTime.Now.ToLongTimeString().ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
