using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L2CountingElements
{
    [TestClass]
    public class TestFrogRiverOne
    {
        [TestMethod]
        public void TestFrogRiverOneMethod1()
        {
            SolutionFrogRiverOne s = new SolutionFrogRiverOne();
            int[] A = {1, 2, 1, 4, 2, 3, 5, 4};
            var result = s.solution(5, A);
            Assert.AreEqual(6, result);
        }
    }

    /// <summary>
    /// <para>A small frog wants to get to the other side of a river.</para>
    /// <para>The frog is currently located at position 0, and wants to get</para>
    /// <para>to position X. Leaves fall from a tree onto the surface of the river.</para>
    /// <para>You are given a non-empty zero-indexed array A consisting of N integers</para>
    /// <para>representing the falling leaves. A[K] represents the position where</para>
    /// <para>one leaf falls at time K, measured in minutes.</para>
    /// <para>The goal is to find the earliest time when the frog can jump to</para>
    /// <para>the other side of the river. The frog can cross only when leaves</para>
    /// <para>appear at every position across the river from 1 to X.</para>
    /// </summary>
    class SolutionFrogRiverOne
    {
        /// <summary>
        /// <para>Given a non-empty zero-indexed array A consisting of N integers</para>
        /// <para>and integer X, returns the earliest time when the frog can jump</para>
        /// <para>to the other side of the river.</para>
        /// <para>If the frog is never able to jump to the other side of the river,</para>
        /// <para>the function should return −1.</para>
        /// </summary>
        /// <param name="X">Frog's desired position.</param>
        /// <param name="A">Zero-indexed array representing falling leaves.</param>
        /// <returns>Earliest time when the frog can jump
        /// to the other side of the river. -1 if not possible.</returns>
        public int solution(int X, int[] A)
        {
            int[] B = new int[X];
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X)
                    if (B[A[i] - 1] != 1)
                    {
                        B[A[i] - 1] = 1;
                        sum++;
                    }
                if (sum == X)
                    return i;
            }
            return -1;
        }
    }      
}
