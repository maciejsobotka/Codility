using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L11FibonacciNumbers
{
    [TestClass]
    public class TestLadder
    {
        [TestMethod]
        public void TestLadderMethod1()
        {
            SolutionLadder s = new SolutionLadder();
            int[] A = { 4, 4, 5, 5, 1 };
            int[] B = { 3, 2, 4, 3, 1 };
            var result = s.solution(A, B);
            int[] expected = { 5, 1, 8, 0, 1 };
            CollectionAssert.AreEqual(expected, result);
        }
    }

    class SolutionLadder
    {
        /// <summary>
        /// Returns number of different ways of climbing laddrs modulo.
        /// </summary>
        /// <param name="A">Array with number of rungs in ladders.</param>
        /// <param name="B">Array with powers for modulo.</param>
        /// <returns>Array with number of different ways of climbing laddrs modulo.</returns>
        public int[] solution(int[] A, int[] B)
        {
            int[] ans = new int[A.Length];
            int mod = 0;
            foreach (var i in B)
                if (i > mod) mod = i;
            int[] steps = Fibonacci(A.Length + 2, 1 << mod);
            for (int i = 0; i < A.Length; ++i)
                ans[i] = steps[A[i] + 1] & (1 << B[i]) - 1;
            return ans;
        }

        /// <summary>
        /// Returns Fibonacci numbers modulo mod.
        /// </summary>
        /// <param name="L">Fibonacci numbers to count.</param>
        /// <param name="mod">Modulo value.</param>
        /// <returns>Fibonacci numbers modulo mod.</returns>
        public int[] Fibonacci(int L, int mod)
        {                           // mod to avoid big integers
            int[] steps = new int[L];
            steps[0] = 0;
            steps[1] = 1;
            for (int i = 2; i < L; ++i)
                steps[i] = (steps[i - 1] + steps[i - 2]) & (mod - 1);
            return steps;
        }
    }
}
