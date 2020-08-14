using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Programmers.Level2.Tests
{
    [TestClass()]
    public class HashCamouflageTests
    {
        private Dictionary<string[,], int> _samples = new Dictionary<string[,], int>();

        [TestInitialize]
        public void Init()
        {
            AddSamples(new string[,] { { "yellow_hat", "headgear" }, { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" } }, 5);
            AddSamples(new string[,] { { "crow_mask", "face" }, { "blue_sunglasses", "face" }, { "smoky_makeup", "face" } }, 3);
        }

        private void AddSamples(string[,] clothes, int result)
        {
            _samples.Add(clothes, result);
        }

        [TestMethod()]
        [DataRow("HashCamouflage_DD")]
        public void SolutionTest(string solutionClassName)
        {
            try
            {
                IHashCamouflage solutionClass = GetSolutionClass(solutionClassName);

                bool testReuslt = true;

                foreach(var sample in _samples)
                {
                    int expectedResult = sample.Value;
                    int result         = solutionClass.Solution(sample.Key);

                    if(result == expectedResult)
                    {
                        Debug.WriteLine("PASS");
                    }
                    else
                    {
                        Debug.WriteLine($"FAIL, result: {result}, expected result: {expectedResult}");

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

        private IHashCamouflage GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.Level2.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return Activator.CreateInstance(objectType) as IHashCamouflage;
            }
            catch
            {
                throw;
            }
        }
    }
}