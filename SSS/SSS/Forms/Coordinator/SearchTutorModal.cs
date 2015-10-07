using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS.Forms.Tutor;
using SSS.Properties;
using SSS_Library.WindowHandler;

namespace SSS.Forms.Coordinator
{
    public partial class SearchTutorModal : Form
    {
        private readonly IS2G10_DBSSSDataSet.GROUPDataTable _group;

        private readonly int _coordinatorId;
        private readonly bool _isUpdateTutor;
        private int _groupId;

        public SearchTutorModal(int coordintaorId, bool isUpdateTutor)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _coordinatorId = coordintaorId;
            _isUpdateTutor = isUpdateTutor;
            _group = groupTableAdapter1.GetData();
            _groupId = PopulateGroupComboBox();
            isAssignedGroupCheckBox.Checked = true;
        }

        //TODO if null
        public int PopulateGroupComboBox()
        {
            for (int i = 0; i < _group.Count; i++)
            {
                ComboBoxHandler.ComboboxItem item = new ComboBoxHandler.ComboboxItem
                {
                    Text = String.Format("{0}", _group.Rows[i].ItemArray[1]),
                    Value = _group.Rows[i].ItemArray[0]
                };

                groupComboBox.Items.Add(item);
            }
            groupComboBox.SelectedIndex = 0;
            return Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem)?.Value.ToString());
        }

        private void SearchTutorModal_Load(object sender, EventArgs e)
        {
            this.sEARCH_TUTORTableAdapter.Fill(iS2G10_DBSSSDataSet.SEARCH_TUTOR, _groupId);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var tutorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            IS2G10_DBSSSDataSet.SEARCH_TUTORRow tutor;
            if (isAssignedGroupCheckBox.Checked)
            {
                tutor = sEARCH_TUTORTableAdapter.GetData(_groupId).FindBytutor_id(tutorId);
            }
            else
            {
                tutor = sEARCH_TUTORTableAdapter.GetDataAll().FindBytutor_id(tutorId);
            }
            if (!_isUpdateTutor)
            {
                displayStudentInformation(tutor);
            }
            else
            {
                SSS.Coordinator coordinator = (SSS.Coordinator)Application.OpenForms["Coordinator"];
                var updateTutorModal = new UpdateTutorModal(tutorId);
                coordinator.SetModal(updateTutorModal);
                this.Hide();
                updateTutorModal.Show();
            }
        }

        private void isAssigned_CheckedChanged(object sender, EventArgs e)
        {
            if (isAssignedGroupCheckBox.Checked)
            {
                //has group
                groupComboBox.SelectedItem = 1;
                groupComboBox.Enabled = true;
                this.sEARCH_TUTORTableAdapter.Fill(iS2G10_DBSSSDataSet.SEARCH_TUTOR, _groupId);
                dataGridView1.DataSource = sEARCH_TUTORTableAdapter.GetData(_groupId);
            }
            else
            {
                //ie no group
                groupComboBox.SelectedItem = -1;
                groupComboBox.Enabled = false;
                this.sEARCH_TUTORTableAdapter.FillAll(iS2G10_DBSSSDataSet.SEARCH_TUTOR);
                dataGridView1.DataSource = sEARCH_TUTORTableAdapter.GetDataAll();
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAssignedGroupCheckBox.Checked)
            {
                _groupId = Convert.ToInt32((groupComboBox.SelectedItem as ComboBoxHandler.ComboboxItem)?.Value.ToString());
                this.sEARCH_TUTORTableAdapter.Fill(iS2G10_DBSSSDataSet.SEARCH_TUTOR, _groupId);
                dataGridView1.DataSource = sEARCH_TUTORTableAdapter.GetData(_groupId);
            }
            else
            {
                this.sEARCH_TUTORTableAdapter.FillAll(iS2G10_DBSSSDataSet.SEARCH_TUTOR);
                dataGridView1.DataSource = sEARCH_TUTORTableAdapter.GetDataAll();
            }
        }

        private void displayStudentInformation(IS2G10_DBSSSDataSet.SEARCH_TUTORRow tutor)
        {
            string trainingstatus;
            if (tutor.tutor_trainingstatus)
                trainingstatus = "Yes";
            else
                trainingstatus = "No";
            var message = String.Format("Student Name: {0} {1}\n" +
                                                                 "Tutor Id: {2}\n" +
                                                                 "Tutor's ID or Passport: {3}\n" +
                                                                 "Date Of Birth: {4}\n" +
                                                                 "Email: {5}\n" +
                                                                 "Mobile Number: {6}\n" +
                                                                 "Training Status: {7}",
                                                                 tutor.tutor_firstname,
                                                                 tutor.tutor_lastname,
                                                                 tutor.tutor_id,
                                                                 tutor.tutor_id_passport,
                                                                 tutor.tutor_dateofbirth.Date.ToShortDateString(),
                                                                 tutor.tutor_emailaddress,
                                                                 tutor.tutor_cellnumber,
                                                                 trainingstatus);
            MessageBox.Show(message, Resources.SearchTutorInformationHeading);
        }
    }
}
