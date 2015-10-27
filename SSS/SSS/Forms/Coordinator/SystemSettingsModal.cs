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
    public partial class SystemSettingsModal : Form
    {
        public SystemSettingsModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void cleanDatabaseButton_Click(object sender, EventArgs e)
        {
            SSS_Library.DataServices.DatabaseOps.CleanDatabase();
            doDbOpButton.Enabled = true;
        }

        private void doDbOpButton_Click(object sender, EventArgs e)
        {
            //TODO implement full settings
            SSS_Library.DataServices.DatabaseOps.ResetAllPasswords();
            MessageBox.Show("All Done.");
        }
    }
}
