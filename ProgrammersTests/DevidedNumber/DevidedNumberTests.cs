using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;
using System.Linq;

namespace Programmers.DevidedNumber.Tests
{
    [TestClass()]
    public class DevidedNumberTests : TestsBase<(int[] arr, int divisor), int[]>
    {
        public override bool GetResult(int[] answer, int[] expectedAnswer)
        {
            return Enumerable.SequenceEqual(answer, expectedAnswer);
        }

        public override void Init()
        {
            AddSample((new int[] { 5, 7, 9, 10 }, 5), new int[] { 5, 10 });
            AddSample((new int[] { 2, 31, 1, 3 }, 1), new int[] { 1, 2, 3, 36 });
            AddSample((new int[] { 3, 2, 6 }, 10), new int[] { -1 });
        }

        [TestMethod()]
        [DataRow("DevidedNumber_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}