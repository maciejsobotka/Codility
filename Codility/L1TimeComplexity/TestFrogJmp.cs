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
    /// A small frog wants to get to the other side of the road.
    /// The frog is currently located at position X and wants to get
    /// to a position greater than or equal to Y.
    /// The small frog always jumps a fixed distance, D.
    /// Count the minimal number of jumps that the small frog must
    /// perform to reach its target.
    /// </summary>
    class SolutionFrogJmp
    {
        /// <summary>
        /// Given three integers X, Y and D, returns the minimal number
        /// of jumps from position X to a position equal to or greater than Y.
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
