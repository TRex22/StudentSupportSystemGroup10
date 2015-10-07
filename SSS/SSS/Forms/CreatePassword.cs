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
        public string password { get; set; }
        public bool createdPassword { get; set; }
        public CreatePassword()
        {
            InitializeComponent();
            this.createdPassword = false;
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check they dont equal
            if (!passwordTxtBox.Text.Equals(confirmPasswordTxtBox.Text))
            {
                MessageBox.Show(Resources.PassWordCreateDoNotMatchError, Resources.PassWordCreateDoNotMatchError);
            }
            else if (passwordTxtBox.Text.Equals(confirmPasswordTxtBox.Text))
            {
                this.password = confirmPasswordTxtBox.Text;
                this.createdPassword = true;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.password = null;
            this.createdPassword = false;
            this.Close();
        }
    }
}
