using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Programmers.Level2.Tests
{
    [TestClass()]
    public class TruckCrossingBridgeTests 
    {
        private Dictionary<TruckBridgeSample, int> _samples = new Dictionary<TruckBridgeSample, int>();

        [TestInitialize]
        public void Init()
        {
            AddSamples(new TruckBridgeSample(2, 10, new int[]{ 7,4,5,6}), 8);
            AddSamples(new TruckBridgeSample(100, 100, new int[]{ 10}), 101);
            AddSamples(new TruckBridgeSample(100, 100, new int[]{ 10,10,10,10,10,10,10,10,10,10}), 110);
        }

        private void AddSamples(TruckBridgeSample sample, int result)
        {
            _samples.Add(sample, result);
        }

        [TestMethod()]
        [DataRow("TruckCrossingBridge_yu")]
        public void SolutionTest(string solutionClassName)
        {
            try
            {
                ITruckCrossingBridge truckCrossingBridge = GetSolutionClass(solutionClassName);

                bool testReuslt = true;

                foreach(var sample in _samples)
                {
                    int expectedResult = sample.Value;
                    int result         = truckCrossingBridge.Solution(sample.Key.bridge_lenth, sample.Key.weight, sample.Key.truck_weights);

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

        private ITruckCrossingBridge GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.Level2.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return Activator.CreateInstance(objectType) as ITruckCrossingBridge;
            }
            catch
            {
                throw;
            }
        }
    }
}