using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codility.L5StacksAndQueues
{
    [TestClass]
    public class TestNesting
    {
        [TestMethod]
        public void TestNestingMethod1()
        {
            SolutionNesting s = new SolutionNesting();
            String S = "(()(())())";
            var result = s.solution(S);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestNestingMethod2()
        {
            SolutionNesting s = new SolutionNesting();
            String S = "())";
            var result = s.solution(S);
            Assert.AreEqual(0, result);
        }
    }

    class SolutionNesting
    {
        /// <summary>
        /// <para>Given a string S consisting of N characters, returns 1</para>
        /// <para>if S is properly nested and 0 otherwise.</para>
        /// </summary>
        /// <param name="S">String consisting of brackets characters.</param>
        /// <returns>
        /// <para>1: String properly nested.</para>
        /// <para>0: String not nested properly.</para>
        /// </returns>
        public int solution(string S)
        {
            int l = 0;
            if (String.IsNullOrEmpty(S)) return 1;
            if (S.Length % 2 != 0) return 0;

            foreach (var c in S)
            {
                if (c == '(')
                    l++;
                if (c == ')')
                {
                    l--;
                    if (l < 0)  return 0;
                }
            }
            if (l != 0) return 0;
            return 1;
        }
    }
}
