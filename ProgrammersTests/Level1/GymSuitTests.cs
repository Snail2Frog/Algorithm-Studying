using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programmers.Level1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Programmers.Level1.Tests
{
    [TestClass()]
    public class GymSuitTests
    {
        private Dictionary<(int, int[], int[]), int> _samples = new Dictionary<(int, int[], int[]), int>();

        [TestInitialize]
        public void Init()
        {
            AddSamples((5, new int[] { 2, 4 }, new int[] { 1, 3, 5 } ), 5);
            AddSamples((5, new int[] { 2, 4 }, new int[] { 3       } ), 4);
            AddSamples((3, new int[] { 3    }, new int[] { 1       } ), 2);
        }

        private void AddSamples((int, int[], int[]) input, int output)
        {
            _samples.Add(input, output);
        }

        [TestMethod()]
        [DataRow("GymSuit_DD")]
        public void SolutionTest(string solutionClassName)
        {
            bool testResult = true;

            IGymSuit solutionClass = GetSolutionClass(solutionClassName);

            foreach(var sample in _samples)
            {
                int result = solutionClass.Solution(sample.Key.Item1, sample.Key.Item2, sample.Key.Item3);

                if(result == sample.Value)
                {
                    Debug.WriteLine("PASS");
                }
                else
                {
                    Debug.WriteLine($"FAIL, result: {string.Join(",", result)}, expected result: {string.Join(",", sample.Value)}");

                    testResult = false;
                }
            }

            if(testResult == false)
            {
                Assert.Fail("Test failed. Please check the debug output.");
            }
        }

        private IGymSuit GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.Level1.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return Activator.CreateInstance(objectType) as IGymSuit;
            }
            catch
            {
                throw;
            }
        }
    }
}