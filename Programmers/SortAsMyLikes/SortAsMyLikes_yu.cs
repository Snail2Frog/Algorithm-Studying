using System.Collections.Generic;
using System.Linq;

namespace Programmers.SortAsMyLikes
{
    public class SortAsMyLikes_yu : ISortAsMyLikes
    {
        public string[] Solution((string[] strings, int n) input)
        {
            int n = input.n;
            string[] strings = input.strings;

            Dictionary<string, char> pairs = new Dictionary<string, char>();
            string[] answer = new string[] {};

            int length = strings.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                pairs.Add(strings[i], strings[i][n]);
            }

            answer = pairs.OrderBy(d=>d.Value).ThenBy(d=>d.Key).Select(d=>d.Key).ToArray();
            
            return answer;
        }
    }
}
