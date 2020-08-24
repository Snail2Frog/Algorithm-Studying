using System.Linq;

namespace Programmers.Level1
{
    public class Printer_yu : IPrinter
    {
        public int Solution(int[] priorities, int location)
        {
            int answer = 1;

            int length = priorities.GetLength(0);
            int[] answerArr = new int[length];
            
            int highPriority = priorities.Max();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (highPriority == priorities[j])
                    {
                        answerArr[j] = answer;
                        answer++;
                        priorities[j] = 0;
                        highPriority = priorities.Max();
                        if (highPriority == 0)
                        {
                            return answerArr[location];
                        }
                    }
                }
            }

            return answerArr[location];
        }
    }
}
