using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L12BinarySearchAlgorithm
{
    [TestClass]
    public class TestMinMaxDivision
    {
        [TestMethod]
        public void TestMinMaxDivisionMethod1()
        {
            SolutionMinMaxDivision s = new SolutionMinMaxDivision();
            int[] A = { 2, 1, 5, 1, 2, 2, 2 };
            int K = 3, M = 5;
            var result = s.solution(K, M, A);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMinMaxDivisionMethod2()
        {
            SolutionMinMaxDivision s = new SolutionMinMaxDivision();
            int[] A = { 2, 8 };
            int K = 2, M = 8;
            var result = s.solution(K, M, A);
            Assert.AreEqual(8, result);
        }
    }

    class SolutionMinMaxDivision
    {
        /// <summary>
        /// Returns minimal large sum of blocks created from array A.
        /// </summary>
        /// <param name="K">Number of blocks to create</param>
        /// <param name="M">Should be maximal value of array.</param>
        /// <param name="A">Array to be divided into blocks.</param>
        /// <returns>Minimal large sum.</returns>
        public int solution(int K, int M, int[] A)
        {
            int begin = 0, end = 0, mid = 0;
            for(int i = 0; i < A.Length; ++i)
            {
                begin = Math.Max(begin, A[i]);
                end += A[i];
            }
            int minLargeSum = end;
            while ( begin <= end )      // binary search
            {
                mid = (begin + end) / 2;
                if(Blocks(mid , A) <= K)
                {
                    end = mid - 1;
                    minLargeSum = mid;
                }
                else begin = mid + 1;
            }
            return minLargeSum;
        }

        /// <summary>
        /// Returns the number of blocks created frim array A, given maxBlock size.
        /// </summary>
        /// <param name="maxBlock">Maximal sum of a block.</param>
        /// <param name="A">Array to be divided into blocks.</param>
        /// <returns>Number of blocks.</returns>
        public int Blocks(int maxBlock, int[] A)
        {
            int blocks = 1;
            int blockSum = 0;
            foreach (var i in A)
                if (blockSum + i > maxBlock)
                {
                    blocks++;
                    blockSum = i;
                }
                else blockSum += i;
            return blocks;
        }
    }
}
