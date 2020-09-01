using System;

namespace Programmers.StarSquare
{
    public class StarSquare_DD : IStarSquare
    {
        public string Solution(string input)
        {
            string[] s = input.Split(' ');

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);

            for(int i = 0 ; i< b; i++)
            {
                for(int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            return string.Empty;
        }
    }
}
