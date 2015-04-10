using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L3PrefixSums
{
    [TestClass]
    public class TestPassingCars
    {
        [TestMethod]
        public void TestPassingCarsMethod1()
        {
            SolutionPassingCars s = new SolutionPassingCars();
            int[] A = {0, 1, 0, 1, 1};
            var result = s.solution(A);
            Assert.AreEqual(5, result);
        }
    }

    /// <summary>
    /// <para>A non-empty zero-indexed array A consisting of N integers is given.</para>
    /// <para>The consecutive elements of array A represent consecutive</para>
    /// <para>cars on a road.</para>
    /// <para>Array A contains only 0s and/or 1s:</para>
    /// <para>   0 represents a car traveling east,</para>
    /// <para>   1 represents a car traveling west.</para>
    /// <para>The goal is to count passing cars. We say that a pair of cars</para>
    /// <para>(P, Q), where 0 ≤ P &lt; Q &lt; N, is passing when P is</para>
    /// <para>traveling to the east and Q is traveling to the west.</para>
    /// </summary>
    class SolutionPassingCars
    {
        /// <summary>
        /// <para>Given a non-empty zero-indexed array A of N integers,</para>
        /// <para>returns the number of pairs of passing cars.</para>
        /// <para>The function should return −1 if the number of pairs of</para>
        /// <para>passing cars exceeds 1,000,000,000.</para>
        /// </summary>
        /// <param name="A">Array with cars (zeros and ones) on a road. </param>
        /// <returns>Number of pairs of passing cars or -1 if more than 1000000000 pairs.</returns>
        public int solution(int[] A)
        {
            int q = 0;
            int pass = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] == 1)
                    q++;
                if (A[i] == 0)
                    pass += q;
                if (pass > 1000000000)
                    return -1;
            }
            return pass;
        }
    }
}
