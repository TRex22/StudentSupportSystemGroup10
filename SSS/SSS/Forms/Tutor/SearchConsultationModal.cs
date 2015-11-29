using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSS_Library;

namespace SSS_Windows_Forms.Forms.Tutor
{
    public partial class SearchConsultationModal : Form
    {
        private readonly int _coordinatorId;
        private readonly int _tutorId;
        private readonly bool _isTutor = false;
        private int _id = 0;

        public SearchConsultationModal(int coordinatorId, int? tutorId)
        {
            _coordinatorId = coordinatorId;
            if (tutorId != null)
            {
                _isTutor = true;
                _tutorId = (int)tutorId;
            }

            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();
        }

        private void SearchConsultationModal_Load(object sender, EventArgs e)
        {
            dataGridView1.DataBindings.Clear();
            if (_isTutor)
                dataGridView1.DataSource = consultationFullDataTableAdapter.GetData(_coordinatorId).Where(m => m.tutor_id == _tutorId).ToList();
            else
                dataGridView1.DataSource = consultationFullDataTableAdapter.GetData(_coordinatorId);

             _id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Coordinator.Coordinator coordinator = (Coordinator.Coordinator)Application.OpenForms["Coordinator"];
            var updateConsultationModal = new UpdateStudentConsultationModal(_id, _coordinatorId);
            coordinator.SetModal(updateConsultationModal);
            this.Hide();
            updateConsultationModal.Show();
        }

        private void DiasplayButton_Click(object sender, EventArgs e)
        {
            var consultation = consultationFullDataTableAdapter.GetData(_coordinatorId).FirstOrDefault(m => m.consultation_id == _id);
            DisplayConsultationInformation(consultation);
        }

        private void DisplayConsultationInformation(IS2G10_DBSSSDataSet.CONSULTATION_FULL_DATARow consultation)
        {
            string rating;
            if (consultation.consultation_rating == -1)
                rating = "Not Yet Rated";
            else
                rating = ""+ consultation.consultation_rating;

            var message = string.Format("Id: {0}\n"+
                "Date: {1}\n" +
                "Details: {2}\n" +
                "Rating: {3}\n" +
                "Student Id: {4}\n" +
                "Student Name: {5} {6}\n" +
                "Tutor Id: {7}\n" +
                "Tutor Name: {8} {9}", 
                consultation.consultation_id, consultation.consultation_date, consultation.consultation_details, 
                rating, consultation.student_id, consultation.student_firstname, consultation.student_lastname,
                consultation.tutor_id, consultation.tutor_firstname, consultation.tutor_lastname);
            MessageBox.Show(message);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            DiasplayButton.Enabled = true;
            UpdateButton.Enabled = true;
        }
    }
}
