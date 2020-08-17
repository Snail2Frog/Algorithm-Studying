using System;
using System.Collections.Generic;
using System.Text;

namespace Programmers.Level2
{
    public class HashCamouflage_yu : IHashCamouflage
    {
        public int Solution(string[,] clothes) 
        {
            int answer = 1;

            Dictionary<string, int> clothesDict = new Dictionary<string, int>();
            int length = clothes.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                if (clothesDict.ContainsKey(clothes[i, 1]))
                {
                    clothesDict[clothes[i, 1]] += 1;
                }
                else
                {
                    clothesDict.Add(clothes[i, 1], 2);
                }
            }

            foreach (var itemNum in clothesDict)
            {
                answer *= itemNum.Value;
            }

            return answer - 1;
        }
    }
}
