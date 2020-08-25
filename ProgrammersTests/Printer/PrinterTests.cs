using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.Printer.Tests
{
    [TestClass()]
    public class PrinterTests : TestsBase<(int[], int), int>
    {
        public override bool GetResult(int answer, int expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((new int[] { 2, 1, 3, 2 }, 2), 1);
            AddSample((new int[] { 1, 1, 9, 1, 1, 1 }, 2), 1);
        }

        [TestMethod]
        [DataRow("Printer_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}