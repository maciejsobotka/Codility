using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L8PrimeAndCompositeNumbers
{
    [TestClass]
    public class TestCountFactors
    {
        [TestMethod]
        public void TestCountFactorsMethod1()
        {
            SolutionCountFactors s = new SolutionCountFactors();
            var result = s.solution(24);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestCountFactorsMethod2()
        {
            SolutionCountFactors s = new SolutionCountFactors();
            var result = s.solution(7);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCountFactorsMethod3()
        {
            SolutionCountFactors s = new SolutionCountFactors();
            var result = s.solution(25);
            Assert.AreEqual(3, result);
        }
    }

    class SolutionCountFactors
    {
        /// <summary>
        /// <para>Given a integer, returns number of it's factors.</para>
        /// </summary>
        /// <param name="N">Integer.</param>
        /// <returns>Number of factors.</returns>
        public int solution(int N)
        {
            int factors = 0;
            for (int i = 1; i <= Math.Sqrt(N); i++)
                if (N % i == 0)
                {
                    if (i == Math.Sqrt(N)) factors++;
                    else factors = factors + 2;
                }
            return factors;
        }
    }
}
