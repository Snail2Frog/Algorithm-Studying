using System.Collections.Generic;

namespace Programmers.Camouflage
{
    public class Camouflage_Others : ICamouflage
    {
        public int Solution(string[,] clothes)
        {
            int answer = 1;

            int clothesCount = clothes.Length / clothes.Rank;

            var clothesDictionary = new Dictionary<string, int>();
            for (int i = 0; i < clothesCount; i++)
            {
                string clothType = clothes[i, 1];

                if (clothesDictionary.ContainsKey(clothes[i, 1]) == false)
                {
                    clothesDictionary.Add(clothType, 1);
                }
                else
                {
                    clothesDictionary[clothType]++;
                }
            }

            foreach (int count in clothesDictionary.Values)
            {
                answer *= count + 1;
            }

            //아무것도 안입는 경우 제외
            return answer - 1;
        }
    }
}
