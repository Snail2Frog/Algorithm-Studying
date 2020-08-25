using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;
using System.Linq;

namespace Programmers.KthNumber.Tests
{
    [TestClass()]
    public class KthNumberTests : TestsBase<(int[], int[,]), int[]>
    {
        public override bool GetResult(int[] answer, int[] expectedAnswer)
        {
            return Enumerable.SequenceEqual(answer, expectedAnswer);
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } }), new int[] { 5, 6, 3 });
        }

        [TestMethod]
        [DataRow("KthNumber_DD")]
        [DataRow("KthNumber_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}