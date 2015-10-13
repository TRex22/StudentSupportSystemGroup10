using System;
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
    public partial class SystemControl : Form
    {
        public SystemControl()
        {
            InitializeComponent();
        }

        private void GenerateActivities()
        {
            //10004
            UpdateActivitiesPerStudent(10004);
            //10005
            UpdateActivitiesPerStudent(10005);
            //10010
            UpdateActivitiesPerStudent(10010);
            //10013
            UpdateActivitiesPerStudent(10013);
        }

        private void UpdateActivitiesPerStudent(int studentId)
        {
            Random rnd = new Random();

            var activitiesTable = studenT_ACTIVITYTableAdapter1.GetData();
            foreach (var activity in activitiesTable)
            {
                int tutorRating = rnd.Next(1, 3);
                int activityRating = rnd.Next(3, 5);
                var newAttendance = attendanceTableAdapter1.Insert(studentId, activity.student_activity_id, tutorRating, activityRating, true);
            }
        }

        private void GenerateUserProfiles()
        {
            //quick hack
            var tutors = tutorTableAdapter1.GetData();
            foreach (var tutor in tutors)
            {
                userprofileTableAdapter1.Insert(tutor.tutor_id, tutor.tutor_emailaddress, null, null, tutor.tutor_id, null, null, null, null, false, true);
            }

            var students = studentTableAdapter1.GetData();
            foreach (var student in students)
            {
                userprofileTableAdapter1.Insert(student.student_id, student.student_emailaddress, student.student_id, null, null, null, null, null, null, false, true);
            }

            var coordinators = ssS_COORDINATORTableAdapter1.GetData();
            foreach (var coordinator in coordinators)
            {
                userprofileTableAdapter1.Insert(coordinator.coordinator_id, coordinator.coordinator_emailaddress, null, coordinator.coordinator_id, null, null, null, null, null, false, true);
            }
        }
    }
}
