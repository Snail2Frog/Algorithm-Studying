using System.Collections.Generic;
using System.Linq;

namespace Programmers.KthNumber
{
    public class KthNumber_DD : IKthNumber
    {
        public int[] Solution((int[] array, int[,] commands) input)
        {
            int[]  array    = input.array   ;
            int[,] commands = input.commands;

            List<int> answer = new List<int>();

            int caseCount = commands.Length / 3;
            for (int index = 0; index < caseCount; index++)
            {
                int skip  = commands[index, 0] - 1;
                int take  = commands[index, 1] - skip;
                int order = commands[index, 2];

                var filteredArray = array.Skip(skip);
                filteredArray = filteredArray.Take(take);
                filteredArray = filteredArray.OrderBy(f => f);

                var selectedNumber = filteredArray.ElementAt(order - 1);

                answer.Add(selectedNumber);
            }

            return answer.ToArray();
        }
    }
}
