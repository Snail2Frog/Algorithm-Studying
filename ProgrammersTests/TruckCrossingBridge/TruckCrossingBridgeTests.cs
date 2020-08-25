using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.TruckCrossingBridge.Tests
{
    [TestClass()]
    public class TruckCrossingBridgeTests : TestsBase<(int, int, int[]), int>
    {
        public override bool GetResult(int answer, int expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((2, 10, new int[] { 7, 4, 5, 6 }), 8);
            AddSample((100, 100, new int[] { 10 }), 101);
            AddSample((100, 100, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }), 110);
            AddSample((2, 5, new int[] { 1, 1, 1, 1, 1, 1, 1 }), 9);
        }

        [TestMethod]
        [DataRow("TruckCrossingBridge_DD")]
        [DataRow("TruckCrossingBridge_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}