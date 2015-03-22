using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Codility.L1TimeComplexity
{
    [TestClass]
    public class TestFrogJmp
    {
        [TestMethod]
        public void TestFrogJmpMethod1()
        {
            SolutionFrogJmp s = new SolutionFrogJmp();
            var result = s.solution(10, 85, 30);
            Assert.AreEqual(3, result);
        }
    }

    /// <summary>
    /// <para>A small frog wants to get to the other side of the road.</para>
    /// <para>The frog is currently located at position X and wants to get</para>
    /// <para>to a position greater than or equal to Y.</para>
    /// <para>The small frog always jumps a fixed distance, D.</para>
    /// <para>Count the minimal number of jumps that the small frog must</para>
    /// <para>perform to reach its target.</para>
    /// </summary>
    class SolutionFrogJmp
    {
        /// <summary>
        /// <para>Given three integers X, Y and D, returns the minimal number</para>
        /// <para>of jumps from position X to a position equal to or greater than Y.</para>
        /// </summary>
        /// <param name="X">Frog's position.</param>
        /// <param name="Y">Frog's desired position.</param>
        /// <param name="D">Frog's jump distance.</param>
        /// <returns></returns>
        public int solution(int X, int Y, int D)
        {
            if ((Y - X) % D == 0)
                return (Y - X) / D;
            else
                return (Y - X) / D + 1;
        }
    }
}
