using System.Collections.Generic;

namespace Programmers.Year2016
{
    public class Year2016_DD2 : IYear2016
    {
        public string Solution((int a, int b) input)
        {
            int a = input.a;
            int b = input.b;

            var dayOfWeek = new List<string> { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };

            var day31Months = new List<int>() { 1, 3, 5, 7, 8, 10, 12 };
            var day30Months = new List<int>() { 4, 6, 9, 11};
            var daysInMonth = new Dictionary<int, int>();

            foreach(int month in day31Months)
            {
                daysInMonth.Add(month, 31);
            }
            foreach(int month in day30Months)
            {
                daysInMonth.Add(month, 30);
            }
            daysInMonth.Add(2, 29);

            int totaldays = 0;
            for(int month = 1; month <= 12; month++)
            {
                int days = daysInMonth[month];
                if(month == a)
                {
                    for(int day = 1; day <= days; day++)
                    {
                        if(day == b)
                        {
                            break;
                        }

                        totaldays++;
                    }

                    break;
                }

                totaldays += days;
            }

            return dayOfWeek[totaldays%dayOfWeek.Count];
        }
    }
}
