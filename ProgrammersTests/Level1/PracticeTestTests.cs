using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Programmers.Level1.Tests
{
    [TestClass()]
    public class PracticeTestTests
    {
        private Dictionary<int[], int[]> _samples = new Dictionary<int[], int[]>();

        [TestInitialize]
        public void Init()
        {
            AddSamples(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1 } );
            AddSamples(new int[] { 1, 3, 2, 4, 2 }, new int[] { 1, 2, 3 } );
        }

        private void AddSamples(int[] answers, int[] highestScorers)
        {
            _samples.Add(answers, highestScorers);
        }

        [TestMethod()]
        [DataRow("PracticeTest_DD")]
        public void SolutionTest(string solutionClassName)
        {
            try
            {
                IPracticeTest practiceTest = GetSolutionClass(solutionClassName);

                bool testReuslt = true;

                foreach(var sample in _samples)
                {
                    int[] expectedResult = sample.Value;
                    int[] result         = practiceTest.Solution(sample.Key);

                    if(result.Length == expectedResult.Length
                    && result.Except(expectedResult).Count() == 0)
                    {
                        Debug.WriteLine("PASS");
                    }
                    else
                    {
                        Debug.WriteLine($"FAIL, result: {string.Join(",", result)}, expected result: {string.Join(",", expectedResult)}");

                        testReuslt = false;
                    }
                }

                if(testReuslt == false)
                {
                    Assert.Fail("Test failed. Please check the debug output.");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }

        private IPracticeTest GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.Level1.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return Activator.CreateInstance(objectType) as IPracticeTest;
            }
            catch
            {
                throw;
            }
        }
    }
}