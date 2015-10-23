using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class SearchConsultationModal : Form
    {
        private readonly int _coordinatorId;
        public SearchConsultationModal(int coordinatorId)
        {
            _coordinatorId = coordinatorId;
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void SearchConsultationModal_Load(object sender, EventArgs e)
        {
            cONSULTATIONFULLDATARowBindingSource = consultationFullDataTableAdapter.GetData(_coordinatorId);
        }
    }
}
