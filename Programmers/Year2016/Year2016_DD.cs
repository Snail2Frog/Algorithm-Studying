using System;

namespace Programmers.Year2016
{
    public class Year2016_DD : IYear2016
    {
        public string Solution((int a, int b) input)
        {
            int a = input.a;
            int b = input.b; 

            var dateTime = new DateTime(2016, a, b);

            return dateTime.DayOfWeek.ToString().Substring(0,3).ToUpper();
        }
    }
}
