using System;
using System.Linq;
using System.Windows.Forms;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class UpdateStudentConsultationModal : Form
    {
        private readonly SSS_Library.IS2G10_DBSSSDataSet.CONSULTATION_FULL_DATARow _consultation;
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.CONSULTATION_FULL_DATATableAdapter _consultationFullTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.CONSULTATION_FULL_DATATableAdapter();
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.CONSULTATIONTableAdapter _consultationTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.CONSULTATIONTableAdapter();

        private readonly int _tutorId;
        private readonly bool _isTutor = false;

        public UpdateStudentConsultationModal(int consultationId, int coordinatorId, int? tutorId)
        {
            if (tutorId != null)
            {
                _isTutor = true;
                _tutorId = (int)tutorId;
            }

            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            _consultation = _consultationFullTableAdapter.GetData(coordinatorId).FirstOrDefault(m => m.consultation_id == consultationId);
            PopulateData();
        }

        private void PopulateData()
        {
            tutorComboBox.Text = "" + _consultation.tutor_firstname + " " + _consultation.tutor_lastname;
            tutorComboBox.Enabled = false;
            //TODO get tutor dates for combobox
            dateComboBox.Text = "" + _consultation.consultation_date.ToShortDateString();
            dateComboBox.Enabled = false;
            timeComboBox.Text = "" + _consultation.consultation_date.ToShortTimeString();
            timeComboBox.Enabled = false;
            ArrivedCheckBox.Checked = _consultation.student_arrived;
            detailsTextBox.Text = "" + _consultation.consultation_details;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var consult = _consultationTableAdapter.GetData().FindByconsultation_id(_consultation.consultation_id);
            //consult.consultation_date = //TODO change when time implemented
            consult.student_arrived = ArrivedCheckBox.Checked;
            consult.consultation_details = detailsTextBox.Text;

            _consultationTableAdapter.Update(consult);
            MessageBox.Show(SSS_Library.Properties.Resources.UpdateConsultationSuccess, SSS_Library.Properties.Resources.UpdateConsultationSuccess);
        }

        private void cancelConsultationButton_Click(object sender, EventArgs e)
        {
            //delete this @#$@%
            var consult = _consultationTableAdapter.GetData().FindByconsultation_id(_consultation.consultation_id);
            _consultationTableAdapter.Delete(consult.consultation_id, consult.coordinator_id, consult.tutor_id, 
                consult.student_id, consult.consultation_details, consult.consultation_date, consult.student_arrived, consult.consultation_rating);
            MessageBox.Show(SSS_Library.Properties.Resources.DeleteConsultationSuccess, SSS_Library.Properties.Resources.DeleteConsultationSuccess);
            updateButton.Enabled = false;
            cancelConsultationButton.Enabled = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (_isTutor)
            {
                Tutor tutor = (Tutor)Application.OpenForms["Tutor"];
                this.Hide();
                tutor._searchConsultationModal.Show();
                ClearForm();
            }
            else
            {
                Coordinator.Coordinator coordinator = (SSS_Windows_Forms.Forms.Coordinator.Coordinator)Application.OpenForms["Coordinator"];
                this.Hide();
                coordinator._searchStudentConsultationModal.Show();
                ClearForm();
            }
        }

        private void ClearForm()
        {
            tutorComboBox.Text = "";
            tutorComboBox.Enabled = false;
            dateComboBox.Text = "";
            dateComboBox.Enabled = false;
            timeComboBox.Text = "";
            timeComboBox.Enabled = false;
            ArrivedCheckBox.Checked = false;
            ArrivedCheckBox.Enabled = false;
            detailsTextBox.Text = "";
            detailsTextBox.Enabled = false;
        }
    }
}
