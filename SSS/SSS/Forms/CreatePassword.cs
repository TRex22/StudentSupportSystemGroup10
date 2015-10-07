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
using SSS_Library.PasswordHandler;

namespace SSS.Forms
{
    public partial class CreatePassword : Form
    {
        private readonly PasswordBuilder _passwordBuilder = new PasswordBuilder(new StringHandler());
        public string password { get; set; }
        public CreatePassword()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            password = null;
            lblPassword.Text = "";
            lblPass.Text = "";
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check they dont equal
            if (!lblPass.Text.Equals(lblPassword.Text))
            {
                MessageBox.Show(Resources.PassWordCreateDoNotMatchError, Resources.PassWordCreateDoNotMatchError);
            }
            else
            {
                this.password = lblPass.Text;
                this.Close();
            }
        }
    }
}
