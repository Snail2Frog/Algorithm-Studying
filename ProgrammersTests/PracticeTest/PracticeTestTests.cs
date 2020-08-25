using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;
using System.Linq;

namespace Programmers.PracticeTest.Tests
{
    [TestClass()]
    public class PracticeTestTests : TestsBase<int[], int[]>
    {
        public override bool GetResult(int[] answer, int[] expectedAnswer)
        {
            return Enumerable.SequenceEqual(answer, expectedAnswer);
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1 });
            AddSample(new int[] { 1, 3, 2, 4, 2 }, new int[] { 1, 2, 3 });
        }

        [TestMethod]
        [DataRow("PracticeTest_DD")]
        [DataRow("PracticeTest_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}