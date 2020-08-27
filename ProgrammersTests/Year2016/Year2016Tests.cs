using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammersTests;
using System;

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
            DateTime dateTime = new DateTime(2016, 1, 1);

            while(dateTime < new DateTime(2017, 1, 1))
            {
                AddSample((dateTime.Month, dateTime.Day), dateTime.DayOfWeek.ToString().Substring(0,3).ToUpper());

                dateTime = dateTime.AddDays(1);
            }
        }

        [TestMethod]
        [DataRow("Year2016_DD")]
        [DataRow("Year2016_DD2")]
        [DataRow("Year2016_yu")]
        public override void Test(string solutionClassName)
        {
            SolutionTest(solutionClassName);
        }
    }
}