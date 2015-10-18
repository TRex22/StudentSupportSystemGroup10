using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Coordinator.TutorTraining
{
    public partial class TutorsWithTrainingModal : Form
    {
        public TutorsWithTrainingModal()
        {
            InitializeComponent();
        }

        private void TutorsWithTrainingModal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
