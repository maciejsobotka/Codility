using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L8PrimeAndCompositeNumbers
{
    [TestClass]
    public class TestMinPerimeterRectangle
    {
        [TestMethod]
        public void TestMinPerimeterRectangleMethod1()
        {
            SolutionMinPerimeterRectangle s = new SolutionMinPerimeterRectangle();
            var result = s.solution(30); ;
            Assert.AreEqual(22, result);
        }
    }

    class SolutionMinPerimeterRectangle
    {
        /// <summary>
        /// <para>Given an integer N, returns the minimal perimeter of any rectangle</para>
        /// <para>whose area is exactly equal to N.</para>
        /// </summary>
        /// <param name="N">Integer.</param>
        /// <returns>Minimal perimeter of any rectangle whose area is exactly equal to N.</returns>
        public int solution(int N)
        {
            int min = 2 * (1 + N);
            for (int i = 2; i <= Math.Sqrt(N); i++)
                if (N % i == 0)
                    min = Math.Min(min, 2 * (i + N / i));
            return min;
        }
    }
}
