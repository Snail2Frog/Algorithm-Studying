using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.SumOfArray.Tests
{
    [TestClass()]
    public class SumOfArrayTests : TestsBase<(int[,] arr1, int[,] arr2), int[,]>
    {
        public override bool GetResult(int[,] answer, int[,] expectedAnswer)
        {
            int rows    = answer.GetLength(0);
            int columns = answer.GetLength(1);

            bool result = true;
            for(int row = 0; row < rows; row++)
            {
                for(int column = 0; column < columns; column++)
                {
                    if(answer[row, column] != expectedAnswer[row, column])
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
        
        [TestInitialize]
        public override void Init()
        {
            AddSample((new int[,] { { 1,2,3 }, { 2,3,4 }, { 2,3,4 }, { 2,3,4 } }, new int[,] { { 3,4,5 }, { 5,6,7 }, { 5,6,7 }, { 5,6,7 } }), new int[,] { { 4,6,8 }, { 7,9,11 }, { 7,9,11 }, { 7,9,11 } });
            AddSample((new int[,] { { 1,2 }, { 2,3 } }, new int[,] { { 3,4 }, { 5,6 } }), new int[,] { { 4,6 }, { 7,9 } });
            AddSample((new int[,] { { 1 }, { 2 } }, new int[,] { { 3 }, { 4 } }), new int[,] { { 4 }, { 6 } });
        }

        [TestMethod]
        [DataRow("SumOfArray_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}