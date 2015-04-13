using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L14GreedyAlgorithms
{
    [TestClass]
    public class TestTieRopes
    {
        [TestMethod]
        public void TestTieRopesMethod1()
        {
            SolutionTieRopes s = new SolutionTieRopes();
            int[] A = { 1, 2, 3, 4, 1, 1, 3 };
            int K = 4;
            var result = s.solution(K, A);
            Assert.AreEqual(3, result);
        }
    }

    class SolutionTieRopes
    {
        /// <summary>
        /// <para>Given an integer K and a non-empty zero-indexed array A</para>
        /// <para>of N integers, returns the maximum number of ropes of length</para>
        /// <para>greater than or equal to K that can be created.</para>
        /// </summary>
        /// <param name="K">Samllest desiredrope length.</param>
        /// <param name="A">Array with ropes.</param>
        /// <returns>Maximum number of ropes of length
        /// greater than or equal to K that can be created.</returns>
        public int solution(int K, int[] A)
        {
            int ropes = 0;
            int sum = 0;
            foreach(var i in A)
            {
                sum += i;
                if (sum >= K)
                {
                    ropes++;
                    sum = 0;
                }
            }
            return ropes;
        }
    }
}
