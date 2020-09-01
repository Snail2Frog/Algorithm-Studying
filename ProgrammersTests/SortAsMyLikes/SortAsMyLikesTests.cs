using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;
using System.Linq;

namespace Programmers.SortAsMyLikes.Tests
{
    [TestClass()]
    public class SortAsMyLikesTests : TestsBase<(string[], int), string[]>
    {
        public override bool GetResult(string[] answer, string[] expectedAnswer)
        {
            return Enumerable.SequenceEqual(answer, expectedAnswer);
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample((new string[] { "sun", "bed", "car"}, 1) , new string[] { "car", "bed", "sun"});
            AddSample((new string[] { "abce", "abcd", "cdx"}, 2) , new string[] { "abcd", "abce", "cdx"});
        }

        [TestMethod]
        [DataRow("SortAsMyLikes_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}