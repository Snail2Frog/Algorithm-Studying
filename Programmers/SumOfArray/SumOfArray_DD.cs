namespace Programmers.SumOfArray
{
    public class SumOfArray_DD : ISumOfArray
    {
        public int[,] Solution((int[,] arr1, int[,] arr2) input)
        {
            int[,] arr1 = input.arr1;
            int[,] arr2 = input.arr2;

            int rows    = arr1.GetLength(0);
            int columns = arr1.GetLength(1);

            int[,] answer = new int[rows, columns];

            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    answer[row, column] = (arr1[row, column] + arr2[row, column]);
                }
            }

            return answer;
        }
    }
}
