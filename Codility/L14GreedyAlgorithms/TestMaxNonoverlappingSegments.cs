using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L14GreedyAlgorithms
{
    [TestClass]
    public class TestMaxNonoverlappingSegments
    {
        [TestMethod]
        public void TestMaxNonoverlappingSegmentsMethod1()
        {
            SolutionMaxNonoverlappingSegments s = new SolutionMaxNonoverlappingSegments();
            int[] A = { 1, 3, 7, 9, 9 };
            int[] B = { 5, 6, 8, 9, 10 };
            var result = s.solution(A, B);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMaxNonoverlappingSegmentsMethod2()
        {
            SolutionMaxNonoverlappingSegments s = new SolutionMaxNonoverlappingSegments();
            int[] A = { 1, 3, 9, 9, 10 };
            int[] B = { 5, 6, 9, 11, 11 };
            var result = s.solution(A, B);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMaxNonoverlappingSegmentsMethod3()
        {
            SolutionMaxNonoverlappingSegments s = new SolutionMaxNonoverlappingSegments();
            int[] A = { 1, 3, 6 };
            int[] B = { 5, 6, 9 };
            var result = s.solution(A, B);
            Assert.AreEqual(2, result);
        }
    }

    class SolutionMaxNonoverlappingSegments
    {
        /// <summary>
        /// <para>given two zero-indexed arrays A and B consisting of N integers,</para>
        /// <para>returns the size of a non-overlapping set containing a</para>
        /// <para>maximal number of segments.</para>
        /// </summary>
        /// <param name="A">Beginings of segments.</param>
        /// <param name="B">Endings of segments.</param>
        /// <returns>Size of a non-overlapping set containing a maximal
        /// number of segments.</returns>
        public int solution(int[] A, int[] B)
        {
            if (A.Length == 0) return 0;
            int point = B[0];
            int ans = 1;
            for(int i=0; i< A.Length-1; ++i)
            {
                if (point < A[i + 1])
                {
                    ans++;
                    point = B[i + 1];
                }
            }
            return ans;
        }
    }
}
