using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.HidingPhoneNumber.Tests
{
    [TestClass()]
    public class HidingPhoneNumberTests : TestsBase<string, string>
    {
        public override bool GetResult(string answer, string expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample("01033334444", "*******4444");
            AddSample("027778888", "*****8888");
        }

        [TestMethod]
        [DataRow("HidingPhoneNumber_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}