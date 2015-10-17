using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Windows_Forms.Forms.Student
{
    public partial class StudentDashboardModal : Form
    {
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter _studentTableAdapter1;
        private readonly int _userId;
        private readonly SSS_Library.IS2G10_DBSSSDataSet.STUDENTDataTable _studentDataTable;
        public StudentDashboardModal(int userId)
        {
            _studentTableAdapter1 = new STUDENTTableAdapter()
            {
                ClearBeforeFill = true
            };
            _userId = userId;
            _studentDataTable = new SSS_Library.IS2G10_DBSSSDataSet.STUDENTDataTable();
            _studentDataTable.ImportRow(this._studentTableAdapter1.GetData().FindBystudent_id(_userId));
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void StudentDashboardModal_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
