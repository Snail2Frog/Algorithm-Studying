using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.Budget.Tests
{
    [TestClass()]
    public class BudgetTests : TestsBase<(int[] d, int budget), int>
    {
        public override bool GetResult(int answer, int expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((new int[] { 1, 3, 2, 5, 4 }, 9), 3);
            AddSample((new int[] { 2, 2, 3, 3 }, 10), 4);
        }

        [TestMethod]
        [DataRow("Budget_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}