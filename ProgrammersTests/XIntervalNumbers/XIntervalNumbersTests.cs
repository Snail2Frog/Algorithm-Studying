using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;
using System.Linq;

namespace Programmers.XIntervalNumbers.Tests
{
    [TestClass()]
    public class XIntervalNumbersTests : TestsBase<(int x, int n), long[]>
    {
        public override bool GetResult(long[] answer, long[] expectedAnswer)
        {
            return Enumerable.SequenceEqual(answer, expectedAnswer);
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((2, 5), new long[] { 2, 4, 6, 8, 10 });
            AddSample((4, 3), new long[] { 4, 8, 12 });
            AddSample((-4, 2), new long[] { -4, -8 });
        }

        [TestMethod]
        [DataRow("XIntervalNumbers_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}