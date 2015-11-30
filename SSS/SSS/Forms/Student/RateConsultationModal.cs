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
using SSS_Library.WindowHandler;

namespace SSS_Windows_Forms.Forms.Student
{
    public partial class RateConsultationModal : Form
    {
        private readonly int _studentId;
        private List<IS2G10_DBSSSDataSet.CONSULTATIONRow> _attendedConsultations;
        private IS2G10_DBSSSDataSet.CONSULTATIONRow _consultation;

        public RateConsultationModal(int studentId)
        {
            _studentId = studentId;
            InitializeComponent();
            this.TopLevel = false;
            this.AutoScroll = true;
            this.Hide();

            groupBox1.Enabled = false;
            button1.Enabled = false;
            listView1.Select();
        }

        private void PopulateData()
        {
            listView1.View = View.Details;
            _attendedConsultations = consultationTableAdapter1.GetData().Where(m => m.student_arrived == true && m.student_id == _studentId).ToList();
            if (_attendedConsultations == null || !_attendedConsultations.Any())
            {
                //MessageBox.Show(SSS_Library.Properties.Resources.NoConsultationsAttendedError);
                //listView1.Enabled = false;
            }
            else
            {
                foreach (IS2G10_DBSSSDataSet.CONSULTATIONRow t in _attendedConsultations)
                {
                    ListViewItem item = new ListViewItem(new[] { t.consultation_date.ToLongDateString(), t.consultation_details, t.consultation_id.ToString()});
                    listView1.Items.Add(item);
                }
                //listView1.Items[0].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rating = 0;
            if (radioButton1.Checked)
                rating = 1;
            if (radioButton2.Checked)
                rating = 2;
            if (radioButton3.Checked)
                rating = 3;
            if (radioButton4.Checked)
                rating = 4;
            if (radioButton5.Checked)
                rating = 5;

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                _consultation.consultation_rating = rating;
                consultationTableAdapter1.Update(_consultation);
                MessageBox.Show(SSS_Library.Properties.Resources.ConsultationRatingSuccess, SSS_Library.Properties.Resources.ConsultationRatingSuccess);
            }
            else
            {
                MessageBox.Show(SSS_Library.Properties.Resources.ConsultationNotRatedError, SSS_Library.Properties.Resources.ConsultationNotRatedError);
            }
        }

        private void ClearRadioButtons()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearRadioButtons();
            
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text);

                if (selectedId > 0)
                {
                    groupBox1.Enabled = true;
                    button1.Enabled = true;

                    _consultation = consultationTableAdapter1.GetData().FindByconsultation_id(selectedId);
                    MessageBox.Show(String.Format("Consultation on {0} has been selected", _consultation.consultation_date.ToLongDateString()));
                    
                    switch (_consultation.consultation_rating)
                    {
                        case 1:
                            radioButton1.Select();
                            break;
                        case 2:
                            radioButton2.Select();
                            break;
                        case 3:
                            radioButton3.Select();
                            break;
                        case 4:
                            radioButton4.Select();
                            break;
                        case 5:
                            radioButton5.Select();
                            break;
                        default: //nothing
                            break;
                    }
                }
            }
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            listView1.Enabled = true;
            listView1.Items.Clear();
            PopulateData();
        }
    }
}
