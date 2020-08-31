using System.Linq;

namespace Programmers.Budget
{
    public class Budget_DD : IBudget
    {
        public int Solution((int[] d, int budget) input)
        {
            int[] d = input.d;
            int budget = input.budget;

            var sortedParts = d.OrderBy(p=>p);

            int total     = 0;
            int partCount = 0;
            foreach(int part in sortedParts)
            {
                if((total + part) <= budget)
                {
                    total += part;
                    partCount++;
                    continue;
                }

                break;
            }

            return partCount;
        }
    }
}
