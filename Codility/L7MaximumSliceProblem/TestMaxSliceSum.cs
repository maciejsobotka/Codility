using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L7MaximumSliceProblem
{
    [TestClass]
    public class TestMaxSliceSum
    {
        [TestMethod]
        public void TestMaxSliceSumMethod1()
        {
            SolutionMaxSliceSum s = new SolutionMaxSliceSum();
            int[] A = { 3, 2, -6, 4, 0 };
            var result = s.solution(A); ;
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMaxSliceSumMethod2()
        {
            SolutionMaxSliceSum s = new SolutionMaxSliceSum();
            int[] A = { -4, -3, -6 };
            var result = s.solution(A); ;
            Assert.AreEqual(-3, result);
        }
    }

    class SolutionMaxSliceSum
    {
        /// <summary>
        /// <para>Given an array A consisting of N integers,</para>
        /// <para>returns the maximum sum of any slice of A.</para>
        /// </summary>
        /// <param name="A">Array of integers.</param>
        /// <returns>Maximum sum of any slice of A.</returns>
        public int solution(int[] A)
        {
            int maxEnding = A[0], maxSlice = A[0];

            for (int i = 1; i < A.Length; ++i)
            {
                maxEnding = Math.Max(A[i], maxEnding + A[i]);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }
            return maxSlice;
        }
    }
}
