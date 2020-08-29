using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.SumOfTwoNumbers.Tests
{
    [TestClass()]
    public class SumOfTwoNumbersTests : TestsBase<(int, int), long>
    {
        public override bool GetResult(long answer, long expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((-10000000 , -9999998), -29999997);
            AddSample((3, 5), 12);
            AddSample((3, 3), 3);
            AddSample((5, 3), 12);
        }

        [TestMethod()]
        [DataRow("SumOfTwoNumbers_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}