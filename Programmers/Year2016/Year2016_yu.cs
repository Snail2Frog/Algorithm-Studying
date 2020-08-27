using System.Collections.Generic;
using System.Linq;

namespace Programmers.Year2016
{
    public class Year2016_yu : IYear2016
    {
        public string Solution((int a, int b) input)
        {
            int a = input.a;
            int b = input.b;
            
            string answer = "";
            string[] dayOfWeek = {"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};
            int index = 5; //금요일부터 시작
            int[] month31 = { 1, 3, 5, 7, 8, 10, 12 };
            Dictionary<int, int> daysOfMonth = new Dictionary<int, int>();
            for (int i = 1; i < 13; i++)
            {
                if (month31.Contains(i))
                {
                    daysOfMonth.Add(i, 31);
                }
                else if(i == 2)  
                {
                    daysOfMonth.Add(i, 29);
                }
                else
                {
                    daysOfMonth.Add(i, 30);
                }
            }

            index += daysOfMonth.Where(d=>d.Key < a).Sum(d=>d.Value);
            index += b - 1; //인덱스는 0부터라서 -1
            answer = dayOfWeek[index % 7];

            return answer;
        }
    }
}
