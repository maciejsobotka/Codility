using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L2CountingElements
{
    [TestClass]
    public class TestPermCheck
    {
        [TestMethod]
        public void TestPermCheckMethod1()
        {
            SolutionPermChceck s = new SolutionPermChceck();
            int[] A = {4, 1, 3, 2};
            int[] B = {4, 1, 3};

            var result = s.solution(A);
            var result2 = s.solution(B);
            Assert.AreEqual(1, result);
            Assert.AreEqual(0, result2);
        }
    }
    /// <summary>
    /// A non-empty zero-indexed array A consisting of N integers is given.
    /// A permutation is a sequence containing each element from 1 to N
    /// once, and only once.
    /// </summary>
    class SolutionPermChceck
    {
        /// <summary>
        /// Given a zero-indexed array A, returns 1 if array A is a
        /// permutation and 0 if it is not.
        /// </summary>
        /// <param name="A">Zero-indexed array of integers.</param>
        /// <returns>1 if array A is apermutation and
        /// 0 if it is not.</returns>
        public int solution(int[] A)
        {
            int[] B = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > A.Length)
                    return 0;
                if (B[A[i] - 1] == 1)
                    return 0;
                B[A[i] - 1] = 1;
            }
            for (int i = 0; i < B.Length; i++)
                if (B[i] != 1)
                    return 0;
            return 1;
        }
    }
}
