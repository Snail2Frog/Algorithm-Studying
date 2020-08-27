using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProgrammersTests;

namespace Programmers.GymSuit.Tests
{
    [TestClass()]
    public class GymSuitTests : TestsBase<(int, int[], int[]), int>
    {
        public override bool GetResult(int answer, int expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((5, new int[] { 2, 4 }, new int[] { 1, 3, 5 }), 5);
            AddSample((5, new int[] { 4, 2 }, new int[] { 3 }), 4);
            AddSample((3, new int[] { 3 }, new int[] { 1 }), 2);
        }

        [TestMethod]
        [DataRow("GymSuit_yu")]
        [DataRow("GymSuit_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}