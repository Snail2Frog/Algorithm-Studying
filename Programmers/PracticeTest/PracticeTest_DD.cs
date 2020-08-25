using System.Collections.Generic;

namespace Programmers.PracticeTest
{
    public class PracticeTest_DD : IPracticeTest
    {
        public int[] Solution(int[] answers)
        {
            List<int[]> nerdPatterns = new List<int[]>();

            nerdPatterns.Add(new int[] { 1, 2, 3, 4, 5 });
            nerdPatterns.Add(new int[] { 2, 1, 2, 3, 2, 4, 2, 5 });
            nerdPatterns.Add(new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 });

            var highScorers = new List<int>();
            int highestScore = 0;
            int nerdNumber = 1;
            foreach (var nerdPattern in nerdPatterns)
            {
                var nerdPatternCount = nerdPattern.Length;

                int index = 0;
                int score = 0;
                foreach (var answer in answers)
                {
                    if (answer == nerdPattern[(index % nerdPatternCount)])
                    {
                        score++;
                    }

                    index++;
                }

                if (score >= highestScore)
                {
                    if (score > highestScore)
                    {
                        highScorers.Clear();
                    }

                    highestScore = score;
                    highScorers.Add(nerdNumber);
                }

                nerdNumber++;
            }

            return highScorers.ToArray();
        }
    }
}
