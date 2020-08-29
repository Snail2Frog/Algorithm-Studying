namespace Programmers.SumOfTwoNumbers
{
    public class SumOfTwoNumbers_yu : ISumOfTwoNumbers
    {
        public long Solution((int a, int b) input)
        {
            int a = input.a;
            int b = input.b;

            long answer = 0;

            if (a == b)
            {
                return a;
            }
            else
            {
                int lowNumber = a < b ? a : b;
                int highNumber = a > b ? a : b;

                for (int i = lowNumber; i <= highNumber; i++)
                {
                    answer += i;
                }

                return answer;
            }
        }
    }
}

