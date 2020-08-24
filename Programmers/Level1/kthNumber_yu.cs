using System.Collections.Generic;
using System.Linq;

namespace Programmers.Level1
{
    public class KthNumber_yu : IkthNumber
    {
        public int[] Solution(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();
            List<int> findAnswer = new List<int>();
            int commandsCount = commands.GetLength(0);
            for (int i = 0; i < commandsCount; i++)
            {
                int startNum = commands[i, 0];
                int endNum = commands[i, 1];
                int th = commands[i, 2];
                for (int j = startNum - 1; j < endNum; j++)
                {
                    findAnswer.Add(array[j]);
                }
                
                findAnswer.Sort();
                answer.Add(findAnswer.ElementAt(th - 1));

                findAnswer.Clear();
            }

            return answer.ToArray();
        }
    }

    public class KthNumberSample
    {
        public int[] array;
        public int[,] commands;

        public KthNumberSample(int[] array, int[,] commands)
        {
            this.array = array;
            this.commands = commands;
        }
    }
}
