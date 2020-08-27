using System.Linq;

namespace Programmers.DevidedNumber
{
    public class DevidedNumber_yu : IDevidedNumber
    {
        public int[] Solution((int[] arr, int divisor) input)
        {
            int[] arr = input.arr;
            int divisor = input.divisor;

            int[] answer = new int[] { };
            
            var devided = arr.Where(d=>d % divisor == 0).ToList();

            if (devided.Count() > 0)
            {
                devided.Sort();
                answer = devided.ToArray();
            }
            else
            {
                answer = new int[] { -1 };
            }
            return answer;
        }
    }
}
