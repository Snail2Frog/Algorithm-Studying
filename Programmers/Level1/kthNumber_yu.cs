using System;
using System.Collections.Generic;
using System.Text;

namespace Programmers.Level1
{
    public class kthNumber_yu : IkthNumber
    {
        public int[] Solution(int[] array, int[,] commands)
        {
            int[] answer = new int[] {};
            return answer;
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
