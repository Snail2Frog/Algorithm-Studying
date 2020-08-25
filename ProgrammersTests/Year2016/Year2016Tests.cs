using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programmers.Year2016;
using System;
using System.Collections.Generic;
using System.Text;
using ProgrammersTests;

namespace Programmers.Year2016.Tests
{
    [TestClass()]
    public class Year2016Tests : TestsBase<(int a, int b), string>
    {
        public override bool GetResult(string answer, string expectedAnswer)
        {
            return answer == expectedAnswer;
        }

        [TestInitialize]
        public override void Init()
        {
            //AddSample();
        }

        [TestMethod]
        [DataRow("Year2016_DD")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}