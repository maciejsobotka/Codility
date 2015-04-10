using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L4Sorting
{
    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestTriangleMethod1()
        {
            SolutionTriangle s = new SolutionTriangle();
            int[] A = { 10, 2, 5, 1, 8, 20 };
            var result = s.solution(A);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestTriangleMethod2()
        {
            SolutionTriangle s = new SolutionTriangle();
            int[] A = { 10, 50, 5, 1 };
            var result = s.solution(A);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestTriangleMethod3()
        {
            SolutionTriangle s = new SolutionTriangle();
            int[] A = { int.MaxValue, int.MaxValue, int.MaxValue};
            var result = s.solution(A);
            Assert.AreEqual(1, result);
        }
    }

    /// <summary>
    /// <para>A zero-indexed array A consisting of N integers is given.</para>
    /// <para>The triplet (P, Q, R) is triangular i 0 ≤ P &lt; Q &lt; R &lt; N and:</para>
    /// <para>A[P] + A[Q] &gt; A[R]</para>
    /// <para>A[Q] + A[R] &gt; A[P]</para>
    /// <para>A[R] + A[P] &gt; A[Q]</para>
    /// </summary>
    class SolutionTriangle
    {
        /// <summary>
        /// <para>Given a zero-indexed array A consisting of N integers,</para>
        /// <para>returns 1 if there exists a triangular triplet</para>
        /// <para>for this array and returns 0 otherwise.</para>
        /// </summary>
        /// <param name="A">Array of N integers.</param>
        /// <returns>1 if triangular triplet exists 0 otherwise.</returns>
        public int solution(int[] A)
        {
            if (A == null || A.Length < 3)
                return 0;
            Array.Sort(A);
            for(int i=0; i<A.Length-2;++i)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                    return 1;
                if (A[i] >= 0 && A[i] > A[i + 2] - A[i + 1]) // check overflow
                    return 1;
            }
            return 0;
        }
    }
}
