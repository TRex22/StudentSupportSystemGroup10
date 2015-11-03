using System;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Administrator
{
    public partial class Administrator : Form
    {
        private readonly SystemSettingsModal _systemSettingsModal = new SystemSettingsModal();
        private readonly BrandingModal _brandingModal = new BrandingModal();

        public Administrator()
        {
            InitializeComponent();

            lblCoordinatorName.Text = String.Format("Administrator Account");
            tmrSecond.Start();
            InitModals();
        }

        private void InitModals()
        {
            //init internal window
            this.panel7.Controls.Add(_systemSettingsModal);
            this.panel7.Controls.Add(_brandingModal);
        }

        public void SetModal(Control vaule)
        {
            this.panel7.Controls.Add(vaule);
        }

        private void HideAllModals()
        {
            foreach (Form modal in panel7.Controls)
            {
                modal.Hide();
            }
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            lblDate.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _brandingModal.Show();
        }

        private void systemSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllModals();
            _systemSettingsModal.Show();
        }
    }
}
