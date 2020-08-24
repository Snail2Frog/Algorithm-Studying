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
    public class PrinterTests
    {
        private Dictionary<PrinterSample, int> _samples = new Dictionary<PrinterSample, int>();
        
        [TestInitialize]
        public void Init()
        {
            AddSamples(new PrinterSample(new int[]{ 2, 1, 3, 2}, 2), 1);
            AddSamples(new PrinterSample(new int[]{ 1, 1, 9, 1, 1, 1}, 2), 1);

        }
        private void AddSamples(PrinterSample sample, int expectedReturn)
        {
            _samples.Add(sample, expectedReturn);
        }

        [TestMethod()]
        [DataRow("Printer_yu")]
        public void SolutionTest(string solutionClassName)
        {
            try
            {
                IPrinter printer = GetSolutionClass(solutionClassName);

                bool testReuslt = true;

                foreach(var sample in _samples)
                {
                    int expectedResult = sample.Value;
                    int result         = printer.Solution(sample.Key.priorities, sample.Key.location);

                    if(result == sample.Value)
                    {
                        Debug.WriteLine("PASS");
                    }
                    else
                    {
                        Debug.WriteLine($"FAIL");

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

        private IPrinter GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.Level1.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return Activator.CreateInstance(objectType) as IPrinter;
            }
            catch
            {
                throw;
            }
        }
    }
}