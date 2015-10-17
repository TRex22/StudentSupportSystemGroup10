using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Coordinator.LowTutorRatings
{
    public partial class TutorRatingBIndividualModal : Form
    {
        public TutorRatingBIndividualModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void LowTutorRatingB_IndividualModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING' table. You can move, or remove it, as needed.
            try { 
                this.aVERAGE_TUTOR_RATINGTableAdapter.Fill(this.iS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING);
            }
            catch (Exception ex)
            {
                //todo fix db
                var msg = ""+ex;
                //MessageBox.Show(""+ex);
            }
            
            this.reportViewer1.RefreshReport();
        }
    }
}
