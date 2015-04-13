using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L15DynamicProgramming
{
    [TestClass]
    public class TestNumberSolitaire
    {
        [TestMethod]
        public void TestNumberSolitaireMethod1()
        {
            SolutionNumberSolitaire s = new SolutionNumberSolitaire();
            int[] A = { 1, -2, 0, 9, -1, -2 };
            var result = s.solution(A);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestNumberSolitaireMethod2()
        {
            SolutionNumberSolitaire s = new SolutionNumberSolitaire();
            int[] A = { 1, -2, -4, -9, -1, -5, -3, 3, -2 };
            var result = s.solution(A);
            Assert.AreEqual(1, result);
        }
    }

    class SolutionNumberSolitaire
    {
        /// <summary>
        /// Returns the maximal result that can be achieved on the board represented by array A.
        /// </summary>
        /// <param name="A">Board of squares.</param>
        /// <returns>Maximal result that can be achieved on the board.</returns>
        public int solution(int[] A)
        {
            int[] dp = new int[A.Length];
            for (int i = 0; i < dp.Length; ++i) dp[i] = int.MinValue;
            dp[0] = A[0];
            for (int i = 1; i < A.Length; ++i)
            {
                for (int j = 1; j <= i && j <= 6; ++j)
                {
                    dp[i] = Math.Max(dp[i], dp[i - j] + A[i]);
                }
            }
            return dp[A.Length - 1];
        }
    }
}
