using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using SSS_Library.IS2G10_DBSSSDataSetTableAdapters;

namespace SSS_Library.DataServices
{
    public class DatabaseOps
    {
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter _attendanceTableAdapter1 = new ATTENDANCETableAdapter();
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter _studenTActivityTableAdapter1 = new STUDENT_ACTIVITYTableAdapter();
        private static readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter TutorTableAdapter1 = new TUTORTableAdapter();
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter _userprofileTableAdapter1 = new USERPROFILETableAdapter();
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter _studentTableAdapter1 = new STUDENTTableAdapter();
        private readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter _ssSCoordinatorTableAdapter1 = new SSS_COORDINATORTableAdapter();
        private static readonly SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMESTableAdapter _tutorAvailableTimesTableAdapter1 = new TUTOR_AVAILABLE_TIMESTableAdapter();

        public static void CleanDatabase()
        {
            //make database newish
            //reset passwords
            var userProfileTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter();
            var userProfiles = userProfileTableAdapter.GetData();
            foreach (var userProfile in userProfiles)
            {
                userProfile.resetPassword = true;
                userProfileTableAdapter.Update(userProfile);
            }

            var brandingTableAdapter = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.BRANDINGTableAdapter();
            var branding = brandingTableAdapter.GetData();
            branding[0].is_system_clean = true;

            //kill all attendance and stuff like that.
        }

        public void GenerateActivities()
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

        public static void MatchTutorTimesAndDates()
        {
            var tutorTimes = _tutorAvailableTimesTableAdapter1.GetData();
            foreach (var tutorTime in tutorTimes)
            {
                tutorTime.date_free -= tutorTime.date_free.TimeOfDay;
                tutorTime.date_free += tutorTime.available_time;
                _tutorAvailableTimesTableAdapter1.Update(tutorTime);
            }
        }

        public void UpdateActivitiesPerStudent(int studentId)
        {
            Random rnd = new Random();

            var activitiesTable = _studenTActivityTableAdapter1.GetData();
            foreach (var activity in activitiesTable)
            {
                int tutorRating = rnd.Next(1, 3);
                int activityRating = rnd.Next(3, 5);
                var newAttendance = _attendanceTableAdapter1.Insert(studentId, activity.student_activity_id, tutorRating, activityRating, true);
            }
        }

        public void GenerateUserProfiles()
        {
            //quick hack
            var tutors = TutorTableAdapter1.GetData();
            foreach (var tutor in tutors)
            {
                _userprofileTableAdapter1.Insert(tutor.tutor_id, tutor.tutor_emailaddress, 3, null, null, null, null, false, true, null);
            }

            var students = _studentTableAdapter1.GetData();
            foreach (var student in students)
            {
                _userprofileTableAdapter1.Insert(student.student_id, student.student_emailaddress, 4, null, null, null, null, false, true, null);
            }

            var coordinators = _ssSCoordinatorTableAdapter1.GetData();
            foreach (var coordinator in coordinators)
            {
                _userprofileTableAdapter1.Insert(coordinator.coordinator_id, coordinator.coordinator_emailaddress, 2, null, null, null, null, false, true, null);
            }
        }

        public static void GenerateTutorAvailableDates()
        {
            var tutors = TutorTableAdapter1.GetData();
            string[] days = new string[5] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            foreach (var tutor in tutors)
            {
                Random rnd = new Random();
                var rndDay = days[rnd.Next(0, 4)];
                TimeSpan time = new TimeSpan(0, 14, 0, 0, 0);

                var availableDates = CalculateAvailableDateTime(rndDay, time, 38);
                foreach (var date in availableDates)
                {
                    _tutorAvailableTimesTableAdapter1.Insert(rndDay, time, tutor.tutor_id, date, false);
                }
            }

            foreach (var tutor in tutors)
            {
                Random rnd = new Random();
                var rndDay = days[rnd.Next(0, 4)];
                TimeSpan time = new TimeSpan(0, 8, 0, 0, 0);

                var availableDates = CalculateAvailableDateTime(rndDay, time, 38);
                foreach (var date in availableDates)
                {
                    _tutorAvailableTimesTableAdapter1.Insert(rndDay, time, tutor.tutor_id, date, false);
                }
            }
        }

        public static List<DateTime> CalculateAvailableDateTime(string day, TimeSpan time, int numberOfDays)
        {
            List <DateTime> availableDates = new List<DateTime>(); 
            string[] days = new string[5] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            for (int i = 1; i <= numberOfDays; i++)
            {
                //from now till num days calculate dates available and times
                DateTime aDate = DateTime.Now.AddDays(i);
                aDate.Add(time);
                string theDay = aDate.DayOfWeek.ToString();

                if (day.Equals(theDay))
                {
                    availableDates.Add(aDate);
                }
            }
            return availableDates;
        }
    }
}
