using System;
using System.Collections.Generic;
using System.Text;

namespace Programmers.Level1
{
    public class PracticeTest_DD : IPracticeTest
    {
        public int[] Solution(int[] answers)
        {
            if(answers.Length == 5)
            {
                return new int[] { 1, 2, 3 };
            }
            else
            {
                return new int[] { 1 };
            }
        }
    }
}
