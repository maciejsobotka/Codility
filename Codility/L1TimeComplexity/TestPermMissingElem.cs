using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L1TimeComplexity
{
    [TestClass]
    public class TestPermMissingElem
    {
        [TestMethod]
        public void TestPermMissingElemMethod1()
        {
            SolutionPermMissingElem s = new SolutionPermMissingElem();
            int[] A = {3, 1, 2, 4, 6};
            var result = s.solution(A);
            Assert.AreEqual(5, result);
        }
    }

    /// <summary>
    /// A zero-indexed array A consisting of N different integers is given.
    /// The array contains integers in the range [1..(N + 1)], which means that
    /// exactly one element is missing.
    /// Your goal is to find that missing element.
    /// </summary>
    class SolutionPermMissingElem
    {
        /// <summary>
        /// Given a zero-indexed array A, returns the value of the missing
        /// element.
        /// </summary>
        /// <param name="A">arrray of elements.</param>
        /// <returns>value of missing element.</returns>
        public int solution(int[] A)
        {
            int[] B = new int[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
                B[A[i] - 1] = 1;
            for (int i = 0; i < A.Length; i++)
                if (B[i] == 0)
                    return i + 1;
            return A.Length + 1;
        }
    }
}
