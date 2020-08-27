using System.Collections.Generic;

namespace Programmers.DevidedNumber
{
    public class DevidedNumber_DD : IDevidedNumber
    {
        public int[] Solution((int[] arr, int divisor) input)
        {
            int[] arr = input.arr;
            int divisor = input.divisor;

            var devidedNumbers = new List<int>();
            foreach(int number in arr)
            {
                if(number%divisor == 0)
                {
                    devidedNumbers.Add(number);
                }
            }

            if(devidedNumbers.Count > 0)
            {
                devidedNumbers.Sort();
                return devidedNumbers.ToArray();
            }
            else
            {
                return new int[] { -1 };
            }
        }
    }
}
