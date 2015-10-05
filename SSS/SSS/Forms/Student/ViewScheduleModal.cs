using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS.Forms.Student
{
    public partial class ViewScheduleModal : Form
    {
        public ViewScheduleModal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void ViewScheduleModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.GROUP' table. You can move, or remove it, as needed.
            this.gROUPTableAdapter.Fill(this.iS2G10_DBSSSDataSet.GROUP);
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.GROUP' table. You can move, or remove it, as needed.
            this.gROUPTableAdapter.Fill(this.iS2G10_DBSSSDataSet.GROUP);
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.GROUP' table. You can move, or remove it, as needed.
            this.gROUPTableAdapter.Fill(this.iS2G10_DBSSSDataSet.GROUP);
        }
    }
}
