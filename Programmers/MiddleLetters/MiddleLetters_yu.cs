using System.Linq;

namespace Programmers.MiddleLetters
{
    public class MiddleLetters_yu : IMiddleLetters
    {
        public string Solution(string input)
        {
            string s = input;

            string answer;

            if (s.Length % 2 == 0)
            {
                answer = s.Substring(s.Length / 2 - 1, 2);
            }
            else
            {
                answer = s.Substring(s.Length / 2 , 1);
            }

            return answer; 
        }
    }
}
