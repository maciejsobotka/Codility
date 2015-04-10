using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L6Leader
{
    [TestClass]
    public class TestDominator
    {
        [TestMethod]
        public void TestDominatorMethod1()
        {
            SolutionDominator s = new SolutionDominator();
            int[] A = { 3, 4, 3, 2, 3, -1, 3, 3 };
            var result = s.solution(A);
            Assert.AreEqual(6, result);
        }
    }
    class SolutionDominator
    {
        /// <summary>
        /// <para>given a zero-indexed array A consisting of N integers,</para>
        /// <para>returns index of any element of array A in which</para>
        /// <para>the dominator of A occurs.</para>
        /// <para>The function should return −1 if array A does not have a dominator.</para>
        /// </summary>
        /// <param name="A">Array with N integers.</param>
        /// <returns>Dominator of array or -1 if there's none.</returns>
        public int solution(int[] A)
        {
            if (A.Length == 0) return -1;

            int n = 0, index = 0, val = A[0];

            for (int i = 0; i < A.Length; i++)
            {
                if (n == 0)
                {
                    n++;
                    val = A[i];
                    index = i;
                }
                else if (val != A[i]) n--;
                else n++;
            }
            if (n == 0) return -1;

            n = 0;
            foreach (var i in A)
                if (i == val) n++;
            if (n <= A.Length / 2) return -1;
            return index;
        }
    }
}
