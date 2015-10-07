﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS.Forms.Coordinator
{
    public partial class TutorRatingsA_ListModal : Form
    {
        public TutorRatingsA_ListModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void LowTutorRatingsModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.ATTENDANCE' table. You can move, or remove it, as needed.
            this.aTTENDANCETableAdapter.Fill(this.iS2G10_DBSSSDataSet.ATTENDANCE);
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.AVERAGE_RATINGS' table. You can move, or remove it, as needed.
            this.aVERAGE_RATINGSTableAdapter.Fill(this.iS2G10_DBSSSDataSet.AVERAGE_RATINGS);
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING' table. You can move, or remove it, as needed.
            this.aVERAGE_TUTOR_RATINGTableAdapter.Fill(this.iS2G10_DBSSSDataSet.AVERAGE_TUTOR_RATING);

            this.reportViewer1.RefreshReport();
        }
    }
}
