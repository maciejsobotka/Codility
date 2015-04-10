using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L10EuclideanAlgorithm
{
    [TestClass]
    public class TestChocolatesByNumbers
    {
        [TestMethod]
        public void TestChocolatesByNumbersMethod1()
        {
            SolutionChocolatesByNumbers s = new SolutionChocolatesByNumbers();
            var result = s.solution(10, 4);
            Assert.AreEqual(5, result);
        }
    }

    class SolutionChocolatesByNumbers
    {
        /// <summary>
        /// Returns the number of chocolates that you will eat.
        /// </summary>
        /// <param name="N">Number of chocolates</param>
        /// <param name="M">Next chocolate to eat.</param>
        /// <returns>Number of chocolates that you will eat.</returns>
        public int solution(int N, int M)
        {
            return N / Gcd(N, M);
        }

        /// <summary>
        /// Returns gratest common divisor.
        /// </summary>
        /// <param name="a">Bigger number.</param>
        /// <param name="b">Smaller number.</param>
        /// <returns>Gcd of a and b.</returns>
        public int Gcd(int a, int b)
        {
            if (a % b == 0) return b;
            else return Gcd(b, a % b);
        }
    }
}
