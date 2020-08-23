using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programmers.Level1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Programmers.Level1.Tests
{
    [TestClass()]
    public class kthNumberTests 
    {
        private Dictionary<KthNumberSample, int[]> _samples = new Dictionary<KthNumberSample, int[]>();

        [TestInitialize]
        public void Init()
        {
            AddSamples(new KthNumberSample(new int[] { 1,5,2,6,3,7,4 }, new int[,] {{ 2,5,3 },{ 4,4,1 },{ 1,7,3 } }), new int[] { 5,6,3 });
        }

        private void AddSamples(KthNumberSample sample, int[] result)
        {
            _samples.Add(sample, result);
        }

        [TestMethod()]
        [DataRow("PracticeTest_yu")]
        public void SolutionTest(string solutionClassName)
        {
            try
            {
                IkthNumber kthNumber = GetSolutionClass(solutionClassName);

                bool testReuslt = true;

                foreach(var sample in _samples)
                {
                    int[] expectedResult = sample.Value;
                    int[] result         = kthNumber.Solution(sample.Key.array, sample.Key.commands);

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

        private IkthNumber GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.Level1.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return Activator.CreateInstance(objectType) as IkthNumber;
            }
            catch
            {
                throw;
            }
        }
    }
}