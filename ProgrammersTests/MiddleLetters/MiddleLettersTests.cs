using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programmers.MiddleLetters;
using System;
using System.Collections.Generic;
using System.Text;
using ProgrammersTests;

namespace Programmers.MiddleLetters.Tests
{
    [TestClass()]
    public class MiddleLettersTests : TestsBase<string, string>
    {
        public override bool GetResult(string answer, string expectedAnswer)
        {
            return answer.Equals(expectedAnswer);
        }

        [TestInitialize]
        public override void Init()
        {
            AddSample("abcde", "c");
            AddSample("qwer", "we");
        }

        [TestMethod]
        [DataRow("MiddleLetters_DD")]
        [DataRow("MiddleLetters_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}