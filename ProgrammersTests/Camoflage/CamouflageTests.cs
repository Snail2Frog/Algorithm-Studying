using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;

namespace Programmers.Camouflage.Tests
{
    [TestClass()]
    public class CamouflageTests : TestsBase<string[,], int>
    {
        public override bool GetResult(int answer, int expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample(new string[,] { { "yellow_hat", "headgear" }, { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" } }, 5);
            AddSample(new string[,] { { "crow_mask", "face" }, { "blue_sunglasses", "face" }, { "smoky_makeup", "face" } }, 3);
        }

        [TestMethod]
        [DataRow("Camouflage_DD")]
        [DataRow("Camouflage_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}