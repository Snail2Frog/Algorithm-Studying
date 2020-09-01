using System.Collections.Generic;

namespace Programmers.XIntervalNumbers
{
    public class XIntervalNumbers_DD : IXIntervalNumbers
    {
        public long[] Solution((int x, int n) input)
        {
            int x = input.x;
            int n = input.n;

            var answer = new List<long>();

            long item = x;
            for(int index=0; index<n; index++)
            {
                answer.Add(item);

                item += x;
            }

            return answer.ToArray();
        }
    }
}
