using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L13CaterpillarMethod
{
    [TestClass]
    public class TestCountDistinctSlices
    {
        [TestMethod]
        public void TestCountDistinctSlicesMethod1()
        {
            SolutionCountDistinctSlices s = new SolutionCountDistinctSlices();
            int[] A = { 3, 4, 5, 5, 2 };
            int M = 6;
            var result = s.solution(M, A);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestCountDistinctSlicesMethod2()
        {
            SolutionCountDistinctSlices s = new SolutionCountDistinctSlices();
            int[] A = { 2, 2 };
            int M = 3;
            var result = s.solution(M, A);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCountDistinctSlicesMethod3()
        {
            SolutionCountDistinctSlices s = new SolutionCountDistinctSlices();
            int[] A = { 5, 4, 3, 5, 2};
            int M = 6;
            var result = s.solution(M, A);
            Assert.AreEqual(13, result);
        }
    }

    class SolutionCountDistinctSlices
    {
        /// <summary>
        /// Counts the number of distinct slices in array.
        /// </summary>
        /// <param name="M">Highest possible number in array.</param>
        /// <param name="A">Array of integers.</param>
        /// <returns>Number of distinct slices.</returns>
        public int solution(int M, int[] A)
        {
            bool[] used = new bool[M + 1];
            int front = 0, back = 0;
            int distinctSlices = 0;

            while (front < A.Length)
            {
                while (front < A.Length && !used[A[front]])
                {
                    distinctSlices += (front - back + 1);
                    if (distinctSlices > 1000000000) return 1000000000;
                    used[A[front]] = true;
                    front++;
                }
                if (front < A.Length)
                {
                    while (A[back] != A[front])
                    {
                        used[A[back]] = false;
                        back++;
                    }
                    used[A[back]] = false;
                    back++;
                }
            }
            return distinctSlices;
        }
    }
}
