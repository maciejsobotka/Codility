using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Codility.L4Sorting
{
    [TestClass]
    public class TestDistinct
    {
        [TestMethod]
        public void TestDistinctMethod1()
        {
            SolutionDistinct s = new SolutionDistinct();
            int[] A = { 2, 1, 1, 2, 3, 1 };
            var result = s.solution(A);
            Assert.AreEqual(3, result);
        }
    }

    /// <summary>
    /// <para> Given a zero-indexed array A consisting of N integers,</para>
    /// <para> returns the number of distinct values in array A.</para>
    /// </summary>
    class SolutionDistinct
    {
        /// <summary>
        /// <para>Returns the number of distinct values in array.</para>
        /// </summary>
        /// <param name="A">Array of N integers.</param>
        /// <returns>Number of distinct values in array.</returns>
        public int solution(int[] A)
        {
            HashSet<int> B = new HashSet<int>();
            foreach (int i in A)
            {
                B.Add(i);
            }
            return B.Count;
        }
    }
}
