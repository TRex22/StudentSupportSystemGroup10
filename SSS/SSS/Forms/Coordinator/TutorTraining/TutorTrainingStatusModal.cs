﻿using System;
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
    public partial class TutorTrainingStatusModal : Form
    {
        public TutorTrainingStatusModal()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void TutorTrainingStatusModal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}