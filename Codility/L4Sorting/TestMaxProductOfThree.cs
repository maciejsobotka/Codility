using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L4Sorting
{
    [TestClass]
    public class TestMaxProductOfThree
    {
        [TestMethod]
        public void TestMaxProductOfThreeMethod1()
        {
            SolutionMaxProductOfThree s = new SolutionMaxProductOfThree();
            int[] A = { -3, 1, 2, -2, 5, 6};
            var result = s.solution(A); ;
            Assert.AreEqual(60, result);
        }
    }

    /// <summary>
    /// <para> A non-empty zero-indexed array A consisting of N integers is given.</para>
    /// <para> The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R]</para>
    /// <para>(0 ≤ P &lt; Q &lt; R &lt; N).</para>
    /// <para>Your goal is to find the maximal product of any triplet.</para>
    /// </summary>
    class SolutionMaxProductOfThree
    {
        /// <summary>
        /// <para>Calculates maximal product of all possible triplets</para>
        /// </summary>
        /// <param name="A">Array of N integers.</param>
        /// <returns>Maximal product of any triplet.</returns>
        public int solution(int[] A)
        {
            Array.Sort(A);
            return Math.Max(A[0] * A[1] * A[A.Length - 1], A[A.Length - 3] * A[A.Length - 2] * A[A.Length - 1]);
        }
    }
}

