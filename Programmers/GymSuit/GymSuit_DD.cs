using System.Collections.Generic;
using System.Linq;

namespace Programmers.GymSuit
{
    public class GymSuit_DD : IGymSuit
    {
        public int Solution((int n, int[] lost, int[] reserve) input)
        {
            var reserves = new List<int>(input.reserve.OrderBy(i => i));
            var losts = new List<int>(input.lost.OrderBy(i => i));

            var lostReserves = new List<int>();
            foreach (var r in reserves)
            {
                if (losts.Contains(r) == true)
                {
                    lostReserves.Add(r);
                }
            }

            foreach (var lr in lostReserves)
            {
                reserves.Remove(lr);
                losts.Remove(lr);
            }

            foreach (var r in reserves)
            {
                int lucky = r - 1;
                if (losts.Contains(lucky))
                {
                    losts.Remove(lucky);
                    continue;
                }

                lucky = r + 1;
                if (losts.Contains(lucky))
                {
                    losts.Remove(lucky);
                }
            }

            return input.n - losts.Count;
        }
    }
}
