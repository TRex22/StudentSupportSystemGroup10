using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSS
{
    public partial class RegisterGroupModal : Form
    {
        public RegisterGroupModal()
        {
            InitializeComponent();
        }

        private void RegisterGroupModal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iS2G10_DBSSSDataSet.GROUP_AGGREGATE' table. You can move, or remove it, as needed.
            this.gROUP_AGGREGATETableAdapter.Fill(this.iS2G10_DBSSSDataSet.GROUP_AGGREGATE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
