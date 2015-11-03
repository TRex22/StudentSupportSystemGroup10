using System;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Administrator
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
