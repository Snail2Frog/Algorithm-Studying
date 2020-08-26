using System.Collections.Generic;
using System.Linq;

namespace Programmers.Printer
{
    public class Printer_DD : IPrinter
    {
        public int Solution((int[] priorities, int location) input)
        {
            int[] priorities = input.priorities;
            int   location   = input.location  ;

            var waitings = new Queue<(int index,int priority)>();

            int index = 0;
            foreach(int priority in priorities)
            {
                waitings.Enqueue((index, priority));

                index++;
            }

            int printCount = 0;
            while(waitings.Count > 0)
            {
                (int index, int priority) first = waitings.Dequeue();

                int firstPriority = first.priority;

                if(waitings.Where(w => w.priority > firstPriority).Count() > 0)
                {
                    waitings.Enqueue(first);

                    continue;
                }

                printCount++;

                if(first.index == location)
                {
                    break;
                }
            }

            return printCount;
        }
    }
}
