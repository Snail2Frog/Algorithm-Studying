using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Programmers;

namespace ProgrammersTests
{
    public abstract class TestsBase<T1, T2>
    {
        public string ProjectName { get { return GetType().Name.Replace("Tests", string.Empty); } }
        public Dictionary<T1, T2> Samples { get; set; } = new Dictionary<T1, T2>();

        public abstract void Init();

        public abstract void Test(string solutionClassName);

        public void SolutionTest(string solutionClassName)
        {
            try
            {
                bool testResult = true;

                IQuestion<T1, T2> solutionClass = GetSolutionClass(solutionClassName);

                foreach (var sample in Samples)
                {
                    T2 answer = GetAnswer(solutionClass, sample.Key);

                    T2 expectedAnswer = sample.Value;
                    bool result = GetResult(answer, expectedAnswer);

                    if (result == true)
                    {
                        Debug.WriteLine("PASS");
                    }
                    else
                    {
                        Debug.WriteLine($"FAIL, answer: {answer}, expected answer: {expectedAnswer}");

                        testResult = false;
                    }
                }

                if (testResult == false)
                {
                    Assert.Fail("Test failed. Please check the debug output.");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        private IQuestion<T1, T2> GetSolutionClass(string solutionClassName)
        {
            try
            {
                string testName = $"Programmers.{ProjectName}.{solutionClassName}, Programmers";

                var objectType = Type.GetType(testName);

                return (IQuestion<T1, T2>)Activator.CreateInstance(objectType);
            }
            catch
            {
                throw;
            }
        }

        public T2 GetAnswer(IQuestion<T1, T2> solutionClass, T1 input)
        {
            return solutionClass.Solution(input);
        }

        public abstract bool GetResult(T2 answer, T2 expectedAnswer);

        public void AddSample(T1 input, T2 answer)
        {
            Samples.Add(input, answer);
        }
    }
}
