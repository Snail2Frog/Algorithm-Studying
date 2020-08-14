using System.Collections.Generic;
using System.Linq;

namespace Programmers.Level2
{
    public class HashCamouflage_DD : IHashCamouflage
    {
        private int       _answer           = 0;
        private List<int> _clothesCountList = new List<int>();
        private int       _typeCount        = 0;

        public int Solution(string[,] clothes)
        {
            _answer           = 0;
            _clothesCountList = new List<int>();
            _typeCount        = 0;

            int clothesCount = clothes.Length/clothes.Rank;

            var clothesDictionary = new Dictionary<string, int>();
            for(int i = 0; i < clothesCount; i++)
            {
                string clothType = clothes[i,1];

                if(clothesDictionary.ContainsKey(clothes[i,1]) == false)
                {
                    clothesDictionary.Add(clothType, 1);
                }
                else
                {
                    clothesDictionary[clothType]++;
                }
            }

            _clothesCountList = clothesDictionary.Values.ToList();
            
            _typeCount = _clothesCountList.Count;

            for(int index = 0; index < _typeCount; index++)
            {
                int currentCount = _clothesCountList[index];

                _answer += currentCount;

                MultipleTypesCount(currentCount, index);
            }

            return _answer;
        }

        private void MultipleTypesCount(int currentCount, int currentIndex)
        {
            for(int index = currentIndex+1; index < _typeCount; index++)
            {
                int multipleCount = currentCount * _clothesCountList[index];

                _answer += multipleCount;

                MultipleTypesCount(multipleCount, index);
            }
        }
    }
}
