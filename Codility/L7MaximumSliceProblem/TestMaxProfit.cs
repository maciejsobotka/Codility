using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L7MaximumSliceProblem
{
    [TestClass]
    public class TestMaxProfit
    {
        [TestMethod]
        public void TestMaxProfitMethod1()
        {
            SolutionMaxProfit s = new SolutionMaxProfit();
            int[] A = { 23171, 21011, 21123, 21366, 21013, 21367 };
            var result = s.solution(A); ;
            Assert.AreEqual(356, result);
        }
    }

    class SolutionMaxProfit
    {
        /// <summary>
        /// <para>Returns the maximum possible profit from one transaction during</para>
        /// <para>stock period given by array A.</para>
        /// <para>The function should return 0 if it was impossible to gain any profit.</para>
        /// </summary>
        /// <param name="A">Array with stock prices.</param>
        /// <returns>Maximum possible profit or 0 if it was impossible to gain profit.</returns>
        public int solution(int[] A)
        {
            if (A.Length == 0 || A.Length == 1) return 0;

            int lowestPrice = A[0], highestDiff = 0, maxProfit = 0;

            for (int i = 1; i < A.Length; ++i )
            {
                highestDiff = Math.Max(0, A[i] - lowestPrice);
                lowestPrice = Math.Min(lowestPrice, A[i]);
                maxProfit = Math.Max(maxProfit, highestDiff);
            }
            return maxProfit;
        }
    }
}
