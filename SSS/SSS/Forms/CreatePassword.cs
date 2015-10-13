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
        public string Password { get; set; }
        public bool CreatedPassword { get; set; }

        public CreatePassword()
        {
            InitializeComponent();
            this.CreatedPassword = false;
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
                this.Password = confirmPasswordTxtBox.Text;
                this.CreatedPassword = true;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Password = null;
            this.CreatedPassword = false;
            this.Close();
        }
    }
}
