using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L9SieveOfEratosthenes
{
    [TestClass]
    public class TestCountSemiprimes
    {
        [TestMethod]
        public void TestCountSemiprimesMethod1()
        {
            SolutionCountSemiprimes s = new SolutionCountSemiprimes();
            int N = 26;
            int[] P = { 1, 4, 16 };
            int[] Q = { 26, 10, 20 };
            var result = s.solution(N, P, Q);
            int[] expected = { 10, 4, 0 };
            CollectionAssert.AreEqual(expected, result);
        }
    }

    class SolutionCountSemiprimes
    {
        /// <summary>
        /// <para>Returns an array consisting of M elements specifying the</para>
        /// <para>consecutive answers to all the queries.</para>
        /// </summary>
        /// <param name="N">Biggest number in range.</param>
        /// <param name="P">Beginings of ranges.</param>
        /// <param name="Q">Endings of ranges.</param>
        /// <returns></returns>
        public int[] solution(int N, int[] P, int[] Q)
        {
            int[] A = new int[P.Length];
            bool[] semiPrimes = this.semiPrimes(N);

            int[] semiPrimesCount = new int[N + 1];
            int n = 0;
            for (int i = 0; i <= N; ++i) 
            {
                if (semiPrimes[i]) n++;
                semiPrimesCount[i] = n;
            }

            for (int i = 0; i < A.Length; ++i)
            {
                var begin = P[i] - 1;
                var end = Q[i];
                A[i] = semiPrimesCount[end] - semiPrimesCount[begin];
            }
            return A;
        }

        /// <summary>
        /// Finds semiprime numbers in given range.
        /// </summary>
        /// <param name="N">Range.</param>
        /// <returns>Semiprime numbers</returns>
        public bool[] semiPrimes(int N)
        {
            bool[] sieve = new bool[N + 1];
            for (int i = 2; i <= N; ++i)    sieve[i] = true;

            for (int i = 2; i * i <= N; ++i)    // Sieve of Eratosthenes
                if (sieve[i])
                    for (int j = i * i; j <= N; j += i )
                        sieve[j] = false;

            bool[] semiPrimes = new bool[N + 1];
            for (int i = 2; i * i <= N; ++i)
                if (sieve[i])
                    for (int j = i; i * j <= N; ++j)
                        if (sieve[j])
                        {
                            var k = i * j;
                            semiPrimes[k] = true;
                        }
            return semiPrimes;
        }
    }
}
