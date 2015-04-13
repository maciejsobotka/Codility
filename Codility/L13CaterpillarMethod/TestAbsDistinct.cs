using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Codility.L13CaterpillarMethod
{
    [TestClass]
    public class TestAbsDistinct
    {
        [TestMethod]
        public void TestAbsDistinctMethod1()
        {
            SolutionAbsDistinct s = new SolutionAbsDistinct();
            int[] A = { -5, -3, -1, 0, 3, 6 };
            var result = s.solution(A);
            Assert.AreEqual(5, result);
        }
    }

    class SolutionAbsDistinct
    {
        /// <summary>
        /// Returns number of distinct absolute values among the elements of the array.
        /// </summary>
        /// <param name="A">Given values.</param>
        /// <returns>Absolute distinct count.</returns>
        public int solution(int[] A)
        {
            HashSet<int> Set = new HashSet<int>();
            foreach (var i in A)
                Set.Add(i > 0 ? i : -i);
            return Set.Count;
        }
    }
}
