using System.Collections.Generic;
using System.Linq;

namespace Programmers.GymSuit
{
    public class GymSuit_yu : IGymSuit
    {
        public int Solution((int n, int[] lost, int[] reserve) input)
        {
            int n = input.n;
            int[] lost = input.lost;
            int[] reserve = input.reserve;

            int gotSuit = 0;
            List<int> reserveList = new List<int>(reserve);
            List<int> lostList = new List<int>(lost);

            var reservedButLost = lostList.Intersect(reserveList);
            gotSuit += reservedButLost.Count();

            reserveList = reserveList.Except(reservedButLost).ToList();
            lostList = lostList.Except(reservedButLost).ToList();

            lostList.Sort();
            foreach (var lostSuit in lostList)
            {
                int result = 0;

                if (reserveList.Count == 0)
                {
                    break;
                }

                result = reserveList.Find(d => d == lostSuit - 1);
                if (result != 0)
                {
                    reserveList.Remove(result);
                    gotSuit++;
                    continue;
                }

                result = reserveList.Find(d => d == lostSuit + 1);
                if (result != 0)
                {
                    reserveList.Remove(result);
                    gotSuit++;
                }
            }
            return n - lost.Count() + gotSuit;
        }
    }
}
