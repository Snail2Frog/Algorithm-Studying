using System.Collections.Generic;
using System.Linq;

namespace Programmers.PracticeTest
{
    public class PracticeTest_yu : IPracticeTest
    {
        public int[] Solution(int[] answers)
        {
            int[] result = new int[] { };

            Dictionary<int, int[]> patterns = new Dictionary<int, int[]>();
            patterns[1] = new int[] { 1, 2, 3, 4, 5 };
            patterns[2] = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            patterns[3] = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            Dictionary<int, int> corrects = new Dictionary<int, int>();
            corrects[1] = 0;
            corrects[2] = 0;
            corrects[3] = 0;

            int length = answers.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (answers[i] == patterns[j][i % patterns[j].Count()])
                    {
                        corrects[j]++;
                    }
                }
            }

            int max = corrects.Values.Max();
            result = corrects.Where(d => d.Value == max).OrderBy(d => d.Key).Select(d => d.Key).ToArray();

            return result;
        }
    }
}
