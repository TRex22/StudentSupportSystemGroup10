using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_Library.DataServices
{
    public class DateTimeCollection
    {
        public DateTimeCollection()
        {
            CollectionOfDateTimes = new List<DateTimes>();
        }

        public List<DateTimes> CollectionOfDateTimes { get; set; }

        public DateTimes FindDateCollection(DateTimes dateToFind)
        {
            foreach (var dateTimes in CollectionOfDateTimes)
            {
                if (dateTimes.Date.Equals(dateToFind.Date))
                    return dateTimes;
            }

            return null;
        }

        public DateTimes FindDateCollectionByName(string dateToFind)
        {
            foreach (var dateTimes in CollectionOfDateTimes)
            {
                if (dateTimes.Date.ToLongDateString().Equals(dateToFind))
                    return dateTimes;
            }

            return null;
        }
    }

    public class DateTimes
    {
        public DateTime Date { get; set; }
        public List<TimeSpan> Times { get; set; }

        public DateTimes()
        {
            Date = new DateTime();
            Times = new List<TimeSpan>();
        }
    }
}
